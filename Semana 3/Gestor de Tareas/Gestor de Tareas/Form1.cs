using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestor_de_Tareas
{
    public partial class Form1 : Form
    {
        List<Tarea> listaTareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            cmbEstado2.SelectedIndex = 0;
        }

        // Eventos de la Parte 1

        //metodo para actualizar el datagridview
        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        // evento para agregar una tarea
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nuevoCodigo = 0;
            bool continuar = false;
            bool existe = false;
            try
            {
                nuevoCodigo = int.Parse(txtCodigo.Text); // Asumiendo que ya validaste que es número

                continuar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Codigo: "+ex.Message);
                continuar = false;
            }

            if (continuar)
            {
                existe = listaTareas.Any(r => int.Parse(r.Codigo) == nuevoCodigo);
                if (existe)
                {
                    MessageBox.Show("Este código ya existe. No se puede guardar la tarea.");
                }
                else
                {
                    Tarea nueva = new Tarea()
                    {
                        Codigo = nuevoCodigo.ToString(),
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        Fecha = dtpFecha.Value,
                        Lugar = txtLugar.Text,
                        Estado = cmbEstado.SelectedItem.ToString()
                    };


                    listaTareas.Add(nueva);
                    ActualizarGrid();
                    MessageBox.Show("Tarea agregada correctamente.");

                }
            }
            


            

        }
        // codigo para la verificacion del codigo unico
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int valor))
            {
                if (valor < 1000 || valor > 9999)
                {
                    MessageBox.Show("El codigo debe tener 4 digitos");
                    txtCodigo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten números.");
                txtCodigo.Focus();
            }
        }

        //evento para editar la tareea
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvTareas.SelectedRows.Count.ToString());
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }
        }

        //evento para eliminar la tarea
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
            }
        }

        //Evento para cargar datos en los TextBox al seleccionar una fila
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }





        // Eventos de la Parte 2

        private void ActualizarGrid2()
        {
            dgvTareas2.DataSource = null;
            //dgvTareas2.DataSource = listaTareas;
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            string codigoBuscado = txtCodigo2.Text;

            Tarea tareaEncontrada = listaTareas.Find(t => t.Codigo == codigoBuscado);
            if (tareaEncontrada != null)
            {
                MessageBox.Show("Tarea encontrada");
                List<Tarea> resultado = new List<Tarea> { tareaEncontrada };
                dgvTareas2.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna tarea con ese código.");
                dgvTareas2.DataSource = null;
            }


        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            string estadoBuscado = cmbEstado2.SelectedItem.ToString();

            List<Tarea> resultado = new List<Tarea>();

            foreach (Tarea t in listaTareas)
            {
                if (t.Estado == estadoBuscado)
                {
                    resultado.Add(t);
                }
            }

            if (resultado.Count > 0)
            {
                MessageBox.Show("Tareas encontradas");
                dgvTareas2.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna tarea con ese estado.");
                dgvTareas2.DataSource = null;
            }

        }

        private void btnBuscarRangoFecha_Click(object sender, EventArgs e)
        {
            DateTime primero = dtpFechaInicio.Value.Date;
            DateTime segundo = dtpFechaFin.Value.Date;



            List<Tarea> resultado = new List<Tarea>();

            if (primero > segundo)
            {
                MessageBox.Show("Por favor, ingresar bien las fechas");
            }
            else
            {
                foreach (Tarea t in listaTareas)
                {
                    if (t.Fecha.Date >= primero && t.Fecha.Date <= segundo)
                    {
                        resultado.Add(t);
                    }
                }
                if (resultado.Count > 0)
                {
                    MessageBox.Show("Tareas encontradas");
                    dgvTareas2.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna tarea en este rango de fecha.");
                    dgvTareas2.DataSource = null;
                }
            }

                


        }

        private void txt2Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt2Codigo_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int valor))
            {
                if (valor < 1000 || valor > 9999)
                {
                    MessageBox.Show("El codigo debe tener 4 digitos");
                    txtCodigo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten números.");
                txtCodigo.Focus();



            }
        }
    }
}
