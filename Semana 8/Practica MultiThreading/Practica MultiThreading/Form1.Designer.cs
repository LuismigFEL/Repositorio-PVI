namespace Practica_MultiThreading
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.progressQuicksort = new System.Windows.Forms.ProgressBar();
            this.lblQuicksort = new System.Windows.Forms.Label();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.progressSelectionSort = new System.Windows.Forms.ProgressBar();
            this.lblMergeSort = new System.Windows.Forms.Label();
            this.progressMergeSort = new System.Windows.Forms.ProgressBar();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.backgroundWorkerMergeSort = new System.ComponentModel.BackgroundWorker();
            this.chartDatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtbCantidadDatos = new System.Windows.Forms.TextBox();
            this.lblCantidadDatos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblLetrero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(60, 347);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(186, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(60, 376);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(186, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Ordenamiento";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.Location = new System.Drawing.Point(62, 56);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(171, 23);
            this.progressBurbuja.TabIndex = 2;
            // 
            // progressQuicksort
            // 
            this.progressQuicksort.Location = new System.Drawing.Point(62, 125);
            this.progressQuicksort.Name = "progressQuicksort";
            this.progressQuicksort.Size = new System.Drawing.Size(171, 23);
            this.progressQuicksort.TabIndex = 3;
            // 
            // lblQuicksort
            // 
            this.lblQuicksort.AutoSize = true;
            this.lblQuicksort.Location = new System.Drawing.Point(59, 106);
            this.lblQuicksort.Name = "lblQuicksort";
            this.lblQuicksort.Size = new System.Drawing.Size(87, 16);
            this.lblQuicksort.TabIndex = 4;
            this.lblQuicksort.Text = "QuickSort 0%";
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(59, 37);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(75, 16);
            this.lblBurbuja.TabIndex = 5;
            this.lblBurbuja.Text = "Burbuja 0%";
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Location = new System.Drawing.Point(59, 167);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(109, 16);
            this.lblSelectionSort.TabIndex = 8;
            this.lblSelectionSort.Text = "SelectionSort 0%";
            // 
            // progressSelectionSort
            // 
            this.progressSelectionSort.Location = new System.Drawing.Point(62, 186);
            this.progressSelectionSort.Name = "progressSelectionSort";
            this.progressSelectionSort.Size = new System.Drawing.Size(171, 23);
            this.progressSelectionSort.TabIndex = 9;
            // 
            // lblMergeSort
            // 
            this.lblMergeSort.AutoSize = true;
            this.lblMergeSort.Location = new System.Drawing.Point(59, 227);
            this.lblMergeSort.Name = "lblMergeSort";
            this.lblMergeSort.Size = new System.Drawing.Size(92, 16);
            this.lblMergeSort.TabIndex = 10;
            this.lblMergeSort.Text = "MergeSort 0%";
            // 
            // progressMergeSort
            // 
            this.progressMergeSort.Location = new System.Drawing.Point(60, 247);
            this.progressMergeSort.Name = "progressMergeSort";
            this.progressMergeSort.Size = new System.Drawing.Size(173, 23);
            this.progressMergeSort.TabIndex = 11;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(60, 405);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(87, 23);
            this.btnDetener.TabIndex = 12;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.Location = new System.Drawing.Point(153, 405);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(93, 23);
            this.btnReanudar.TabIndex = 13;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // backgroundWorkerMergeSort
            // 
            this.backgroundWorkerMergeSort.WorkerReportsProgress = true;
            this.backgroundWorkerMergeSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMergeSort_DoWork);
            this.backgroundWorkerMergeSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMergeSort_ProgressChanged);
            this.backgroundWorkerMergeSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMergeSort_RunWorkerCompleted);
            // 
            // chartDatos
            // 
            chartArea8.Name = "ChartArea1";
            this.chartDatos.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartDatos.Legends.Add(legend8);
            this.chartDatos.Location = new System.Drawing.Point(311, 83);
            this.chartDatos.Name = "chartDatos";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartDatos.Series.Add(series8);
            this.chartDatos.Size = new System.Drawing.Size(518, 362);
            this.chartDatos.TabIndex = 14;
            this.chartDatos.Text = "chart1";
            // 
            // txtbCantidadDatos
            // 
            this.txtbCantidadDatos.Location = new System.Drawing.Point(60, 319);
            this.txtbCantidadDatos.Name = "txtbCantidadDatos";
            this.txtbCantidadDatos.Size = new System.Drawing.Size(186, 22);
            this.txtbCantidadDatos.TabIndex = 15;
            // 
            // lblCantidadDatos
            // 
            this.lblCantidadDatos.AutoSize = true;
            this.lblCantidadDatos.Location = new System.Drawing.Point(60, 297);
            this.lblCantidadDatos.Name = "lblCantidadDatos";
            this.lblCantidadDatos.Size = new System.Drawing.Size(119, 16);
            this.lblCantidadDatos.TabIndex = 16;
            this.lblCantidadDatos.Text = "Cantidad de Datos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(60, 435);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(186, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblLetrero
            // 
            this.lblLetrero.AutoSize = true;
            this.lblLetrero.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblLetrero.Location = new System.Drawing.Point(307, 33);
            this.lblLetrero.Name = "lblLetrero";
            this.lblLetrero.Size = new System.Drawing.Size(441, 20);
            this.lblLetrero.TabIndex = 18;
            this.lblLetrero.Text = "Grafica de Tiempos de Algoritmos de Ordenamiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 510);
            this.Controls.Add(this.lblLetrero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblCantidadDatos);
            this.Controls.Add(this.txtbCantidadDatos);
            this.Controls.Add(this.chartDatos);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.progressMergeSort);
            this.Controls.Add(this.lblMergeSort);
            this.Controls.Add(this.progressSelectionSort);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.lblQuicksort);
            this.Controls.Add(this.progressQuicksort);
            this.Controls.Add(this.progressBurbuja);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Practica MultiThreading";
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.ProgressBar progressQuicksort;
        private System.Windows.Forms.Label lblQuicksort;
        private System.Windows.Forms.Label lblBurbuja;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.Windows.Forms.Label lblSelectionSort;
        private System.Windows.Forms.ProgressBar progressSelectionSort;
        private System.Windows.Forms.Label lblMergeSort;
        private System.Windows.Forms.ProgressBar progressMergeSort;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnReanudar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMergeSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatos;
        private System.Windows.Forms.TextBox txtbCantidadDatos;
        private System.Windows.Forms.Label lblCantidadDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblLetrero;
    }
}

