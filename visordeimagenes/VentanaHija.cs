using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visordeimagenes
{
    public partial class VentanaHija : Form
    {
        public VentanaHija(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            this.Activated += VentanaHija_Activated;
            this.FormClosing += VentanaHija_FormClosing;
        }

        public PictureBox PictureBox 
        { 
            get { return m_PictureBox; }
        }

        private void VentanaHija_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = menuStrip1;
        }
        private void ajustarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo ajustar, activamos este modo 
            if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si estamos en modo ajustar, desactivamos este modo 
            else if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            //Si selecciono la opcion ajustar saldra checked
            menuImagenAjustar.Checked = this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }

        private void tRotar_Click(object sender, EventArgs e)
        {
            var image = this.PictureBox.Image;
            if (image != null)
            {
                var Osize = image.Size;
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.PictureBox.Size = new Size(Osize.Width, Osize.Height);   
                this.PictureBox.Refresh();
            }
        }

        private void tAñadir_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))
            {
                // Crear un objeto Font con una fuente Arial de 20 puntos
                Font font = new Font("Arial", 20);

                // Crear un objeto SolidBrush con el color blanco
                SolidBrush brush = new SolidBrush(Color.White);

                // Dibujar el texto "Programación Visual" en la posición 0,0 de la imagen
                gfx.DrawString("Programación Visual", font, brush, new Point(0, 0));
            }

            // Refrescar el PictureBox para mostrar la imagen actualizada
            PictureBox.Refresh();
        }

        private void VentanaHija_Activated(object sender, EventArgs e)
        {
            Form mdiContainer = this.MdiParent;

            // Verificar que el MDIContainer no sea nulo 
            if (mdiContainer != null)
            {
                // Concatenar el título de la ventana hija con el título del MDIContainer
                mdiContainer.Text = "Visor de imagenes - " + this.Text;
            }
        }

        private void VentanaHija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form mdiContainer = this.MdiParent;

            // Verificar que el MDIContainer no sea nulo 
            if (mdiContainer != null )
            {
                // Restaurar el título original del MDIContainer
                mdiContainer.Text = "Visor de imagenes";
            }
        }

        private bool escala_grises_aplic = false;
        private void tEscalagrises_Click(object sender, EventArgs e)
        {
            if (!escala_grises_aplic)
            {
                PictureBox pictureBox = this.PictureBox;
                Image imagen = pictureBox.Image;
                    using (Graphics gfx = Graphics.FromImage(imagen))
                    {
                        // Matriz para realizar una transformación al gris 
                        // manteniendo los valores de luminancia correctos 
                        ColorMatrix cm = new ColorMatrix(new float[][]{
                    new float[]{0.3f,0.3f,0.3f,0,0},
                    new float[]{0.59f,0.59f,0.59f,0,0},
                    new float[]{0.11f,0.11f,0.11f,0,0},
                    new float[]{0,0,0,1,0},
                    new float[]{0,0,0,0,1}});
                        ImageAttributes ia = new ImageAttributes();
                        ia.SetColorMatrix(cm);
                    // Utilizar el método DrawImage de gfx para redibujar la 
                    // imagen usando los atributos de imagen especificados por ia
                    gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, ia);
                }
                // Refrescar el picture box 
                this.PictureBox.Refresh();
                escala_grises_aplic = true;
            }
        }
    }
}

