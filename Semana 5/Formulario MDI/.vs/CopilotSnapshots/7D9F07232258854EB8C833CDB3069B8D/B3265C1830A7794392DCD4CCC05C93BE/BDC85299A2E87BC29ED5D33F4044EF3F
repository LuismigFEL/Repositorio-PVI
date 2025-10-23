using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Confirmar edición de celdas en curso
            DGVAsignaturas.EndEdit();

            // Normalizar entradas
            var carnet = (txtCarnet.Text ?? string.Empty).Trim();
            var nombre = (txtNombre.Text ?? string.Empty).Trim();

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(carnet))
            {
                MessageBox.Show("El carnet es obligatorio.");
                txtCarnet.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return;
            }

            // Validar carnet duplicado (ignorar mayúsculas/minúsculas y espacios)
            if (DatosCompartidos.Estudiantes != null &&
                DatosCompartidos.Estudiantes.Any(e1 => string.Equals((e1.Carnet ?? string.Empty).Trim(), carnet, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El carnet ingresado ya está registrado. Ingrese un carnet diferente.");
                txtCarnet.Focus();
                return;
            }

            // Construir lista de asignaturas válida
            var asignaturas = new List<Asignatura>();
            var nombresAsignaturas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataGridViewRow fila in DGVAsignaturas.Rows)
            {
                if (fila.IsNewRow) continue; // omitir fila nueva

                var valAsig = fila.Cells[0].Value;
                var valNota = fila.Cells[1].Value;

                // Si la fila está completamente vacía, omitirla
                bool vacia = (valAsig == null || string.IsNullOrWhiteSpace(valAsig.ToString())) &&
                             (valNota == null || string.IsNullOrWhiteSpace(valNota.ToString()));
                if (vacia) continue;

                // Validar que ambas celdas tengan valor
                if (valAsig == null || string.IsNullOrWhiteSpace(valAsig.ToString()))
                {
                    MessageBox.Show("Hay filas con Asignatura vacía. Complete o elimine las filas incompletas.");
                    return;
                }
                if (valNota == null || string.IsNullOrWhiteSpace(valNota.ToString()))
                {
                    MessageBox.Show("Hay filas con Nota vacía. Complete o elimine las filas incompletas.");
                    return;
                }

                string nombreAsig = valAsig.ToString().Trim();

                // Validar duplicados de asignatura dentro del mismo estudiante
                if (!nombresAsignaturas.Add(nombreAsig))
                {
                    MessageBox.Show($"La asignatura '{nombreAsig}' está repetida. Verifique las filas.");
                    return;
                }

                // Validar y convertir nota
                double nota;
                if (valNota is double d)
                {
                    nota = d;
                }
                else if (valNota is int i)
                {
                    nota = i;
                }
                else if (!double.TryParse(valNota.ToString(), out nota))
                {
                    MessageBox.Show($"La nota de la asignatura '{nombreAsig}' no es numérica válida.");
                    return;
                }

                asignaturas.Add(new Asignatura
                {
                    Nombre = nombreAsig,
                    Nota = nota
                });
            }

            // Debe haber al menos una asignatura válida
            if (asignaturas.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una asignatura con su nota.");
                return;
            }

            // Crear y guardar
            var estudiante = new Estudiante
            {
                Carnet = carnet,
                Nombre = nombre,
                Asignaturas = asignaturas
            };

            DatosCompartidos.Estudiantes.Add(estudiante);
            MessageBox.Show("Datos guardados correctamente");
            this.Close();
        }

        
    }
}
