using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace Practica_MultiThreading
{
    public partial class Form1 : Form
    {
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaQuick;
        private List<int> listaSelection;
        private List<int> listaMergeSort;

        private Thread hiloBurbuja;
        private Thread hiloSelection;

        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuick = new Stopwatch();
        private Stopwatch relojMergeSort = new Stopwatch();
        private Stopwatch relojSelection = new Stopwatch();

        // Pausa / reanudación
        private readonly ManualResetEventSlim pausaEvent = new ManualResetEventSlim(true);

        // Estado ejecución
        private volatile bool enEjecucion = false;
        private volatile bool enPausa = false;
        private volatile bool cancelarSolicitado = false;
        private volatile bool generarBloqueado = false; // NUEVO: bloquea el botón Generar tras hacer clic
        private int algoritmosPendientes = 0;
        private readonly object syncEstado = new object();

        // Logging
        private const int LogEvery = 1000;
        private StringBuilder logBurbuja = new StringBuilder();
        private StringBuilder logSelection = new StringBuilder();
        private StringBuilder logQuick = new StringBuilder();
        private StringBuilder logMerge = new StringBuilder();

        // Contadores
        private int quickPartitions = 0;
        private int mergeOperations = 0;

        public Form1()
        {
            InitializeComponent();

            backgroundWorkerQuickSort.WorkerReportsProgress = true;
            backgroundWorkerQuickSort.WorkerSupportsCancellation = true;

            backgroundWorkerMergeSort.WorkerReportsProgress = true;
            backgroundWorkerMergeSort.WorkerSupportsCancellation = true;

            InicializarChart();
            EstablecerEstado(false, false);
        }

        #region Estado / Botones
        private void EstablecerEstado(bool ejecutando, bool pausa)
        {
            enEjecucion = ejecutando;
            enPausa = pausa;

            if (btnIniciar != null) btnIniciar.Enabled = !ejecutando;
            if (btnDetener != null) btnDetener.Enabled = ejecutando && !pausa;
            if (btnReanudar != null) btnReanudar.Enabled = ejecutando && pausa;
            if (btnLimpiar != null) btnLimpiar.Enabled = true; // Siempre disponible
            if (btnGenerar != null) btnGenerar.Enabled = !ejecutando && !generarBloqueado; // NUEVO: Generar deshabilitado si está bloqueado o en ejecución
        }

        private void MarcarAlgoritmoCompletado()
        {
            lock (syncEstado)
            {
                algoritmosPendientes--;
                if (algoritmosPendientes <= 0)
                {
                    pausaEvent.Set();
                    enEjecucion = false;
                    enPausa = false;
                    if (cancelarSolicitado)
                    {
                        // Si se canceló, limpiamos todo (esto también re-habilita Generar)
                        LimpiarTodo();
                    }
                    else
                    {
                        // Al finalizar normalmente, re-habilitamos Generar
                        generarBloqueado = false; // NUEVO
                        EstablecerEstado(false, false);
                    }
                }
            }
        }
        #endregion

        #region Chart
        private void InicializarChart()
        {
            if (chartDatos.ChartAreas.Count == 0)
                chartDatos.ChartAreas.Add(new ChartArea("Area"));

            chartDatos.Series.Clear();
            var serie = new Series("Tiempos")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
                IsValueShownAsLabel = true
            };
            chartDatos.Series.Add(serie);
            chartDatos.Legends.Clear();
        }

        private void LimpiarChart()
        {
            if (chartDatos.Series.IndexOf("Tiempos") >= 0)
                chartDatos.Series["Tiempos"].Points.Clear();
        }

        private void AgregarTiempoAlChart(string algoritmo, long milisegundos)
        {
            if (chartDatos.InvokeRequired)
            {
                chartDatos.Invoke(new Action(() => AgregarTiempoAlChart(algoritmo, milisegundos)));
                return;
            }
            chartDatos.Series["Tiempos"].Points.AddXY(algoritmo, milisegundos);
        }
        #endregion

        #region Generación de datos
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var control = this.Controls.Find("txtbCantidadDatos", true).FirstOrDefault() as TextBox;
            if (control == null || string.IsNullOrWhiteSpace(control.Text))
            {
                MessageBox.Show("El campo de cantidad está vacío. No se generaron datos.");
                return;
            }

            if (!int.TryParse(control.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese un número válido (>0). No se generaron datos.");
                return;
            }

            Random rnd = new Random();
            listaOriginal = new List<int>(capacity: cantidad);
            for (int i = 0; i < cantidad; i++)
                listaOriginal.Add(rnd.Next(0, Math.Max(1000, cantidad * 10)));

            // Bloquea el botón Generar hasta que termine toda la ejecución o se haga Limpiar
            generarBloqueado = true;                // NUEVO
            if (btnGenerar != null) btnGenerar.Enabled = false; // NUEVO

            MessageBox.Show($"Lista generada correctamente con {cantidad:N0} números.");
        }
        #endregion

        #region Inicio / Control ejecución
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (enEjecucion)
            {
                MessageBox.Show("Ya hay una ejecución en curso.");
                return;
            }
            if (listaOriginal == null || listaOriginal.Count == 0)
            {
                MessageBox.Show("Primero genera los datos.");
                return;
            }

            cancelarSolicitado = false;
            pausaEvent.Set();
            LimpiarChart();

            logBurbuja.Clear();
            logSelection.Clear();
            logQuick.Clear();
            logMerge.Clear();
            quickPartitions = 0;
            mergeOperations = 0;

            listaBurbuja = new List<int>(listaOriginal);
            listaQuick = new List<int>(listaOriginal);
            listaMergeSort = new List<int>(listaOriginal);
            listaSelection = new List<int>(listaOriginal);

            ResetearProgresos();

            algoritmosPendientes = 4;
            EstablecerEstado(true, false);

            hiloBurbuja = new Thread(OrdenarBurbuja) { IsBackground = true };
            hiloBurbuja.Start();

            hiloSelection = new Thread(() => SelectionSort(listaSelection)) { IsBackground = true };
            hiloSelection.Start();

            backgroundWorkerQuickSort.RunWorkerAsync(listaQuick);
            backgroundWorkerMergeSort.RunWorkerAsync(new List<int>(listaMergeSort));
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (!enEjecucion || enPausa) return;
            pausaEvent.Reset();
            EstablecerEstado(true, true);
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            if (!enEjecucion || !enPausa) return;
            pausaEvent.Set();
            EstablecerEstado(true, false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (enEjecucion)
            {
                cancelarSolicitado = true;
                pausaEvent.Set(); // Por si estaba en pausa
                MessageBox.Show("Cancelación solicitada. Se limpiará al terminar la salida de los hilos.");
                return;
            }
            LimpiarTodo();
        }
        #endregion

        #region Métodos de limpieza / reset
        private void ResetearProgresos()
        {
            if (progressBurbuja != null) progressBurbuja.Value = 0;
            if (progressSelectionSort != null) progressSelectionSort.Value = 0;
            if (progressQuicksort != null) progressQuicksort.Value = 0;
            if (progressMergeSort != null) progressMergeSort.Value = 0;

            if (lblBurbuja != null) lblBurbuja.Text = "Burbuja:";
            if (lblSelectionSort != null) lblSelectionSort.Text = "Selection Sort:";
            if (lblQuicksort != null) lblQuicksort.Text = "QuickSort:";
            if (lblMergeSort != null) lblMergeSort.Text = "MergeSort:";
        }

        private void LimpiarTodo()
        {
            listaOriginal = null;
            listaBurbuja = null;
            listaQuick = null;
            listaSelection = null;
            listaMergeSort = null;

            logBurbuja.Clear();
            logSelection.Clear();
            logQuick.Clear();
            logMerge.Clear();

            LimpiarChart();
            ResetearProgresos();

            cancelarSolicitado = false;
            generarBloqueado = false; // NUEVO: tras limpiar, vuelve a permitir Generar
            EstablecerEstado(false, false);
            MessageBox.Show("Se limpió todo el estado.");
        }
        #endregion

        #region Algoritmos
        private void OrdenarBurbuja()
        {
            relojBurbuja.Restart();
            int n = listaBurbuja.Count;

            for (int i = 0; i < n - 1; i++)
            {
                if (cancelarSolicitado) break;
                pausaEvent.Wait();

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (cancelarSolicitado) break;

                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }

                    if ((j & 0x3FF) == 0)
                        pausaEvent.Wait();
                }

                if (i % LogEvery == 0 && !cancelarSolicitado)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    logBurbuja.AppendLine($"Iteración externa i={i:N0} de {n:N0}");
                    this.Invoke(new Action(() =>
                    {
                        progressBurbuja.Value = Math.Min(progreso, 100);
                        lblBurbuja.Text = $"Burbuja: {progreso}%";
                    }));
                }
            }

            relojBurbuja.Stop();
            this.Invoke(new Action(() =>
            {
                if (cancelarSolicitado)
                {
                    lblBurbuja.Text = "Burbuja: Cancelado";
                }
                else
                {
                    progressBurbuja.Value = 100;
                    lblBurbuja.Text = $"Burbuja: Completado en {relojBurbuja.ElapsedMilliseconds} ms";
                }
            }));

            if (!cancelarSolicitado)
            {
                GuardarLogsWord("Burbuja", logBurbuja);
                AgregarTiempoAlChart("Burbuja", relojBurbuja.ElapsedMilliseconds);
            }

            MarcarAlgoritmoCompletado();
        }

        private void SelectionSort(List<int> lista)
        {
            relojSelection.Restart();
            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (cancelarSolicitado) break;
                pausaEvent.Wait();

                int minIndex = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (cancelarSolicitado) break;

                    if (lista[j] < lista[minIndex]) minIndex = j;
                    if ((j & 0x3FF) == 0) pausaEvent.Wait();
                }
                if (cancelarSolicitado) break;

                if (minIndex != i)
                {
                    int temp = lista[i];
                    lista[i] = lista[minIndex];
                    lista[minIndex] = temp;
                }

                if (i % LogEvery == 0 && !cancelarSolicitado)
                {
                    int progreso = (int)((i / (float)lista.Count) * 100);
                    logSelection.AppendLine($"Iteración i={i:N0} de {lista.Count:N0}");
                    this.Invoke(new Action(() =>
                    {
                        progressSelectionSort.Value = Math.Min(progreso, 100);
                        lblSelectionSort.Text = $"Selection Sort: {progreso}%";
                    }));
                }
            }

            relojSelection.Stop();
            this.Invoke(new Action(() =>
            {
                if (cancelarSolicitado)
                {
                    lblSelectionSort.Text = "Selection Sort: Cancelado";
                }
                else
                {
                    progressSelectionSort.Value = 100;
                    lblSelectionSort.Text = $"Selection Sort: Completado en {relojSelection.ElapsedMilliseconds} ms";
                }
            }));

            if (!cancelarSolicitado)
            {
                GuardarLogsWord("SelectionSort", logSelection);
                AgregarTiempoAlChart("Selection", relojSelection.ElapsedMilliseconds);
            }

            MarcarAlgoritmoCompletado();
        }

        private void QuickSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker)
        {
            if (cancelarSolicitado) return;
            pausaEvent.Wait();
            if (izquierda < derecha)
            {
                int pivot = Particionar(lista, izquierda, derecha);
                int currentPartitions = Interlocked.Increment(ref quickPartitions);

                if (!cancelarSolicitado && currentPartitions % LogEvery == 0)
                {
                    int progreso = Math.Min(99, (int)(100.0 * currentPartitions / Math.Max(1, lista.Count)));
                    logQuick.AppendLine($"Partición #{currentPartitions:N0}, rango [{izquierda}..{derecha}], pivote en {pivot}");
                    if (worker.WorkerReportsProgress) worker.ReportProgress(progreso);
                }

                QuickSort(lista, izquierda, pivot - 1, worker);
                QuickSort(lista, pivot + 1, derecha, worker);
            }
        }

        private int Particionar(List<int> lista, int izquierda, int derecha)
        {
            pausaEvent.Wait();
            if (cancelarSolicitado) return izquierda; // retorno seguro

            int pivote = lista[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (cancelarSolicitado) break;

                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
                if ((j & 0x3FF) == 0) pausaEvent.Wait();
            }
            if (!cancelarSolicitado)
            {
                int temp2 = lista[i + 1];
                lista[i + 1] = lista[derecha];
                lista[derecha] = temp2;
            }
            return i + 1;
        }

        private List<int> MergeSortRec(List<int> lista, BackgroundWorker workerMerge)
        {
            if (cancelarSolicitado) return lista;
            pausaEvent.Wait();
            if (lista.Count <= 1) return lista;

            int mid = lista.Count / 2;
            var left = MergeSortRec(lista.GetRange(0, mid), workerMerge);
            var right = MergeSortRec(lista.GetRange(mid, lista.Count - mid), workerMerge);

            if (cancelarSolicitado) return lista;

            var merged = Merge(left, right);

            int op = Interlocked.Increment(ref mergeOperations);
            if (!cancelarSolicitado && op % LogEvery == 0)
            {
                int progreso = Math.Min(99, (int)(100.0 * op / Math.Max(1, listaOriginal.Count)));
                logMerge.AppendLine($"Merge #{op:N0} para sublista de tamaño {merged.Count:N0}");
                if (workerMerge.WorkerReportsProgress) workerMerge.ReportProgress(progreso);
            }
            return merged;
        }

        private void MergeSort(List<int> lista, BackgroundWorker workerMerge)
        {
            var sorted = MergeSortRec(lista, workerMerge);
            if (!cancelarSolicitado)
            {
                lista.Clear();
                lista.AddRange(sorted);
            }
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            if (cancelarSolicitado) return left; // retorno rápido
            List<int> resultado = new List<int>(left.Count + right.Count);
            int i = 0, j = 0;
            while (i < left.Count && j < right.Count)
            {
                if (cancelarSolicitado) break;

                if (left[i] <= right[j]) { resultado.Add(left[i]); i++; }
                else { resultado.Add(right[j]); j++; } // <-- CORRECCIÓN no requerida aquí, mantener la línea previa
            }
            // Nota: restauramos la implementación existente:
            resultado.Clear();
            i = 0; j = 0;
            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j]) { resultado.Add(left[i]); i++; }
                else { resultado.Add(right[j]); j++; }
                if (((i + j) & 0x3FF) == 0) pausaEvent.Wait();
            }
            if (!cancelarSolicitado)
            {
                if (i < left.Count) resultado.AddRange(left.GetRange(i, left.Count - i));
                if (j < right.Count) resultado.AddRange(right.GetRange(j, right.Count - j));
            }
            return cancelarSolicitado ? left : resultado;
        }
        #endregion

        #region BackgroundWorkers
        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojQuick.Restart();
            List<int> lista = (List<int>)e.Argument;
            QuickSort(lista, 0, lista.Count - 1, backgroundWorkerQuickSort);
        }

        private void backgroundWorkerQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (cancelarSolicitado) return;
            progressQuicksort.Value = Math.Min(e.ProgressPercentage, 100);
            lblQuicksort.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            relojQuick.Stop();
            if (cancelarSolicitado)
            {
                lblQuicksort.Text = "QuickSort: Cancelado";
            }
            else
            {
                lblQuicksort.Text = $"QuickSort: Completado en {relojQuick.ElapsedMilliseconds} ms";
                progressQuicksort.Value = 100;
                GuardarLogsWord("QuickSort", logQuick);
                AgregarTiempoAlChart("QuickSort", relojQuick.ElapsedMilliseconds);
            }
            MarcarAlgoritmoCompletado();
        }

        private void backgroundWorkerMergeSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojMergeSort.Restart();
            List<int> lista = (List<int>)e.Argument;
            MergeSort(lista, backgroundWorkerMergeSort);
        }

        private void backgroundWorkerMergeSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (cancelarSolicitado) return;
            progressMergeSort.Value = Math.Min(e.ProgressPercentage, 100);
            lblMergeSort.Text = $"MergeSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerMergeSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            relojMergeSort.Stop();
            if (cancelarSolicitado)
            {
                lblMergeSort.Text = "MergeSort: Cancelado";
            }
            else
            {
                lblMergeSort.Text = $"MergeSort: Completado en {relojMergeSort.ElapsedMilliseconds} ms";
                progressMergeSort.Value = 100;
                GuardarLogsWord("MergeSort", logMerge);
                AgregarTiempoAlChart("MergeSort", relojMergeSort.ElapsedMilliseconds);
            }
            MarcarAlgoritmoCompletado();
        }
        #endregion

        #region Guardar Word
        private void GuardarLogsWord(string algoritmo, StringBuilder contenido)
        {
            Thread sta = new Thread(() =>
            {
                string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LogsOrdenamiento");
                Directory.CreateDirectory(carpeta);
                string nombre = $"{algoritmo}_Logs_{DateTime.Now:yyyyMMdd_HHmmss}.docx";
                string ruta = Path.Combine(carpeta, nombre);

                Word.Application app = null;
                Word.Document doc = null;
                Word.Paragraph p1 = null;
                Word.Paragraph p2 = null;
                Word.Range range = null;

                try
                {
                    app = new Word.Application { Visible = false };
                    doc = app.Documents.Add();

                    p1 = doc.Content.Paragraphs.Add();
                    p1.Range.Text = $"{algoritmo} - Iteraciones del proceso";
                    p1.Range.set_Style("Heading 1");
                    p1.Range.InsertParagraphAfter();

                    p2 = doc.Content.Paragraphs.Add();
                    p2.Range.Text = new string('=', 40);
                    p2.Range.InsertParagraphAfter();

                    range = doc.Content;
                    range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    range.InsertAfter(Environment.NewLine + contenido.ToString());

                    doc.SaveAs2(ruta, Word.WdSaveFormat.wdFormatXMLDocument);
                    doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                    app.Quit(false);
                }
                catch (Exception ex)
                {
                    try { if (doc != null) doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges); } catch { }
                    try { if (app != null) app.Quit(false); } catch { }
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show($"Error al guardar logs de {algoritmo}: {ex.Message}");
                    }));
                }
                finally
                {
                    if (range != null) Marshal.FinalReleaseComObject(range);
                    if (p2 != null) Marshal.FinalReleaseComObject(p2);
                    if (p1 != null) Marshal.FinalReleaseComObject(p1);
                    if (doc != null) Marshal.FinalReleaseComObject(doc);
                    if (app != null) Marshal.FinalReleaseComObject(app);
                }
            });
            sta.IsBackground = true;
            sta.SetApartmentState(ApartmentState.STA);
            sta.Start();
        }
        #endregion
    }

}