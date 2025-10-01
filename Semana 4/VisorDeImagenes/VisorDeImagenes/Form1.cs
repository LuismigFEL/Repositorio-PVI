using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorDeImagenes
{
    public partial class Form1 : Form
    {

        private List<string> listaImagenes = new List<String>();
        private int indiceImagenActual = 0;

        private Bitmap originalImage = null;

        private enum VisionModo
        {
            Normal,
            EscaladeGrises
        }
        private VisionModo visionModoActual = VisionModo.Normal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            // Cargar las imágenes desde una carpeta específica
            string carpetaImagenes = @"C:\Users\auron\Desktop\images";
            string[] extensiones = new[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            DirectoryInfo dir = new DirectoryInfo(carpetaImagenes);

            foreach (string ext in extensiones)
            {
                FileInfo[] files = dir.GetFiles("*" + ext);
                foreach (FileInfo file in files)
                {
                    listaImagenes.Add(file.FullName);
                    cmbImagenes.Items.Add(file.Name);
                }
            }

            if (listaImagenes.Count > 0)
            {
                indiceImagenActual = 0;
                CargarImagen();
            }
            else
            {
                MessageBox.Show("No se encontraron imágenes en la carpeta especificada.");
            }
        }

        private void CargarImagen()
        {
            TSSlabelDireccion.Text = listaImagenes[indiceImagenActual];
            cmbImagenes.SelectedIndex = indiceImagenActual;
            if (indiceImagenActual >= 0 && indiceImagenActual < listaImagenes.Count)
            {
                try
                {
                    originalImage = new Bitmap(TSSlabelDireccion.Text);
                    pictureBox1.Image = (Bitmap)originalImage.Clone();
                    AplicarModoVision();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }

            
            

        }
        private void AplicarModoVision()
        {
            if (originalImage == null) return;

            if (pictureBox1.Image != null)
            {
                var old = pictureBox1.Image;
                pictureBox1.Image = null;
                old.Dispose();
            }

            // Corregir orientación antes de procesar
            Bitmap imagenCorregida = CorregirOrientacion((Bitmap)originalImage.Clone());
            Bitmap imagenProcesada = new Bitmap(imagenCorregida.Width, imagenCorregida.Height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(imagenProcesada))
            {
                g.DrawImage(imagenCorregida, 0, 0);
            }

            if (visionModoActual == VisionModo.EscaladeGrises)
            {
                Rectangle rect = new Rectangle(0, 0, imagenProcesada.Width, imagenProcesada.Height);
                BitmapData bmpData = imagenProcesada.LockBits(rect, ImageLockMode.ReadWrite, imagenProcesada.PixelFormat);

                IntPtr ptr = bmpData.Scan0;
                int bytes = Math.Abs(bmpData.Stride) * imagenProcesada.Height;
                byte[] rgbValues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                for (int y = 0; y < imagenProcesada.Height; y++)
                {
                    for (int x = 0; x < imagenProcesada.Width; x++)
                    {
                        int pos = y * bmpData.Stride + x * 3;
                        byte b = rgbValues[pos];
                        byte g = rgbValues[pos + 1];
                        byte r = rgbValues[pos + 2];

                        int gris = (int)(r * 0.3 + g * 0.59 + b * 0.11);
                        byte gByte = (byte)gris;

                        rgbValues[pos] = gByte;
                        rgbValues[pos + 1] = gByte;
                        rgbValues[pos + 2] = gByte;
                    }
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
                imagenProcesada.UnlockBits(bmpData);
            }

            pictureBox1.Image = imagenProcesada;
        }
        private Bitmap CorregirOrientacion(Bitmap img)
        {
            const int ExifOrientationID = 0x0112;

            if (img.PropertyIdList.Contains(ExifOrientationID))
            {
                var prop = img.GetPropertyItem(ExifOrientationID);
                int orientacion = BitConverter.ToUInt16(prop.Value, 0);

                switch (orientacion)
                {
                    case 3:
                        img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 6:
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 8:
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }

                // Eliminar propiedad para evitar que se vuelva a aplicar
                img.RemovePropertyItem(ExifOrientationID);
            }

            return img;
        }

        private void guardarToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Imagen guardada exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar la imagen: " + ex.Message);
                    }
                }
            }
        }

        private void salirToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void normalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            visionModoActual = VisionModo.Normal;
            AplicarModoVision();

            btnTSMVisionNormal.Checked = true;
            btnTSMVisionEscalaGrises.Checked = false;
        }

        private void escalaDeGrisesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            visionModoActual = VisionModo.EscaladeGrises;
            AplicarModoVision();
            btnTSMVisionNormal.Checked = false;
            btnTSMVisionEscalaGrises.Checked = true;
        }

        private void cenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            //sincronizar los menús
            rbAjustar.Checked = false;
            rbCentrada.Checked = true;
            rbZoom.Checked = false;

            btnTSMCentrar.Checked = true;
            btnTSMAjustar.Checked = false;
            btnTSMZoom.Checked = true;
        }

        private void ajustarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //sincronizar los menús
            rbAjustar.Checked = true;
            rbCentrada.Checked = false;
            rbZoom.Checked = false;

            btnTSMCentrar.Checked = false;
            btnTSMAjustar.Checked = true;
            btnTSMZoom.Checked = false;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //sincronizar los menús
            rbAjustar.Checked = false;
            rbCentrada.Checked = false;
            rbZoom.Checked = true;

            btnTSMCentrar.Checked = false;
            btnTSMAjustar.Checked = false;
            btnTSMZoom.Checked = true;
        }

        private void btnTSMNormal_Click(Object sender, EventArgs e)
        {
            normalToolStripMenuItem_Click_1(sender, e);
            rbNormal.Checked = true;
           // rbEscaladeGrises.Checked = false;
        }

        private void btnTSMVisionEscalaGrises_Click(Object sender, EventArgs e)
        {
            //rbNormal.Checked = false;
            rbEscaladeGrises.Checked = true;
            escalaDeGrisesToolStripMenuItem_Click_1(sender, e);
        }

        private void btnTSMCentrar_Click(object sender, EventArgs e)
        {
            cenToolStripMenuItem_Click(sender, e);
        }

        private void btnTSMAjustar_Click(object sender, EventArgs e)
        {
            ajustarToolStripMenuItem_Click(sender, e);
        }

        private void btnTSMZoom_Click(object sender, EventArgs e)
        {
            zoomToolStripMenuItem_Click(sender, e);
        }

        private void rbNormal_checkedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                rbEscaladeGrises.Checked = false;
                normalToolStripMenuItem_Click_1(sender, e);
            }
        }
        private void rbEscaladeGrises_checkedChanged(object sender, EventArgs e)
        {
            if (rbEscaladeGrises.Checked)
            {
                rbNormal.Checked = false;
                escalaDeGrisesToolStripMenuItem_Click_1(sender, e);
            }

        }

        private void rbCentrada_checkedChanged(object sender, EventArgs e)
        {
            if (rbCentrada.Checked)
            {
                cenToolStripMenuItem_Click(sender, e);
            }
        }
        private void rbAjustar_checkedChanged(object sender, EventArgs e)
        {
            if (rbAjustar.Checked)
            {
                ajustarToolStripMenuItem_Click(sender, e);
            }
        }
        private void rbZoom_checkedChanged(object sender, EventArgs e)
        {
            if (rbZoom.Checked)
            {
                zoomToolStripMenuItem_Click(sender, e);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0) return;
            indiceImagenActual = 0;
            CargarImagen();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0) return;
            indiceImagenActual--;
            if (indiceImagenActual < 0)
            {
                indiceImagenActual = listaImagenes.Count - 1; // Ir a la última imagen
            }
            CargarImagen();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0) return;
            indiceImagenActual++;
            if (indiceImagenActual >= listaImagenes.Count)
            {
                indiceImagenActual = 0; // Ir a la primera imagen
            }
            CargarImagen();
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0) return;
            indiceImagenActual = listaImagenes.Count - 1;
            CargarImagen();
        }

        private void TSSlabelDireccion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TSSlabelDireccion.Text))
            {
                System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{TSSlabelDireccion.Text}\"");
            }
        }

        private void girarALaIzquierda90GradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void girar90ALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
                MessageBox.Show("Imagen copiada al portapapeles.");
            }
        }

        private void cmbImagenes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            indiceImagenActual = cmbImagenes.SelectedIndex;
            CargarImagen();
        }
    }


}
