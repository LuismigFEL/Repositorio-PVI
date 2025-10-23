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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // Usaremos las columnas definidas en el diseñador
            DGVDatos.AutoGenerateColumns = false;

            // Asegurar mapeo de columnas a propiedades de la fuente de datos
            if (DGVDatos.Columns.Contains("CarnetDTG"))
                DGVDatos.Columns["CarnetDTG"].DataPropertyName = "Carnet";
            if (DGVDatos.Columns.Contains("NombreDTG"))
                DGVDatos.Columns["NombreDTG"].DataPropertyName = "Nombre";
            if (DGVDatos.Columns.Contains("AsignaturaDTG"))
                DGVDatos.Columns["AsignaturaDTG"].DataPropertyName = "Asignatura";
            if (DGVDatos.Columns.Contains("NotaDTG"))
                DGVDatos.Columns["NotaDTG"].DataPropertyName = "Nota";

            var estudiantes = DatosCompartidos.Estudiantes;
            if (estudiantes == null || estudiantes.Count == 0)
            {
                DGVDatos.DataSource = null;
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            // Construir una tabla aplanada: una fila por asignatura de cada estudiante
            var tabla = new DataTable();
            tabla.Columns.Add("Carnet", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Asignatura", typeof(string));
            tabla.Columns.Add("Nota", typeof(double));

            foreach (var est in estudiantes)
            {
                if (est == null) continue;
                if (est.Asignaturas == null || est.Asignaturas.Count == 0)
                {
                    // Si se desea mostrar estudiantes sin asignaturas, descomentar:
                    // tabla.Rows.Add(est.Carnet, est.Nombre, string.Empty, 0d);
                    continue;
                }

                foreach (var asig in est.Asignaturas)
                {
                    if (asig == null) continue;
                    var row = tabla.NewRow();
                    row["Carnet"] = est.Carnet;
                    row["Nombre"] = est.Nombre;
                    row["Asignatura"] = asig.Nombre;
                    row["Nota"] = asig.Nota;
                    tabla.Rows.Add(row);
                }
            }

            DGVDatos.DataSource = tabla;
        }
    }
}
