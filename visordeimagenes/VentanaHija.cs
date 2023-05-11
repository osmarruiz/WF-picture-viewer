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
        //las opciones del menustrip1 se muestran en el main menu
        private void VentanaHija_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = menuStrip1;
        }
        //ajusta la ventana hija
        private void ajustarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo ajustar, activamos este modo 
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si estamos en modo ajustar, desactivamos este modo 
            else if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            //Si selecciono la opcion ajustar saldra checked
            menuImagenAjustar.Checked = this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }
        //evento resize de la ventana hija
        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }
        //rota la imagen a 90 grados
        private void tRotar_Click(object sender, EventArgs e)
        {
            var image = this.PictureBox.Image;
            if (image != null)
            {
               
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.PictureBox.Refresh();
            }
        }
        //añade un texto a la imagen
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
        //cambia el titulo del mdi container
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
        //si no hay ninguna ventana hija, el mdicontainer vuelve a su titulo
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

        private Image imagenOriginal;
        //convierte la imagen en escala de grises
        private void tEscalagrises_Click(object sender, EventArgs e)
        {

            if(imagenOriginal == null )
            {
                imagenOriginal = this.PictureBox.Image;
            }
            Image imagen = (Image)imagenOriginal.Clone();

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
            this.PictureBox.Image = imagen;
        }
        //convierte la imagen en escala de rojos
        private void EscalaRojos_Click(object sender, EventArgs e)
        {
            if (imagenOriginal == null)
            {
                imagenOriginal = this.PictureBox.Image;
            }
            Image imagen = (Image)imagenOriginal.Clone();
            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Matriz para eliminar el componente azul y verde, manteniendo solo el componente rojo
                ColorMatrix cm = new ColorMatrix(new float[][]{
                new float[]{1,0,0,0,0},
                new float[]{0,0,0,0,0},
                new float[]{0,0,0,0,0},
                new float[]{0,0,0,1,0},
                new float[]{0,0,0,0,1}});
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);

                // Utilizar el método DrawImage de gfx para redibujar la 
                // imagen usando los atributos de imagen especificados por ia
                gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, ia);
            }
            this.PictureBox.Image = imagen;
        }
        //convierte la imagen en escala de azules
        private void EscalaAzules_Click(object sender, EventArgs e)
        {
            if (imagenOriginal == null)
            {
                imagenOriginal = this.PictureBox.Image;
            }
            Image imagen = (Image)imagenOriginal.Clone();
            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Matriz para eliminar el componente rojo y verde, manteniendo solo el componente azul
                ColorMatrix cm = new ColorMatrix(new float[][]{
            new float[]{0,0,0,0,0},
            new float[]{0,0,0,0,0},
            new float[]{0,0,1,0,0},
            new float[]{0,0,0,1,0},
            new float[]{0,0,0,0,1}});
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);

                // Utilizar el método DrawImage de gfx para redibujar la 
                // imagen usando los atributos de imagen especificados por ia
                gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, ia);
            }
            this.PictureBox.Image = imagen;
        }

        private string ruta = "";
        //guardar la imagen como
        private void guardaComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgGuardar = new SaveFileDialog();
            dlgGuardar.Filter = "Archivos JPEG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Archivos BMP (*.bmp)|*.bmp";
            dlgGuardar.Title = "Guardar imagen como...";
            if (dlgGuardar.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dlgGuardar.FileName).ToLower();
                ImageFormat formato;
                switch (extension)
                {
                    case ".jpg":
                        formato = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        formato = ImageFormat.Png;
                        break;
                    case ".bmp":
                        formato = ImageFormat.Bmp;
                        break;
                    default:
                        MessageBox.Show("Formato de archivo no soportado.");
                        return;
                }
                ruta = dlgGuardar.FileName;
                PictureBox.Image.Save(dlgGuardar.FileName, formato);
                this.Text = Path.GetFileName(dlgGuardar.FileName);
                Form mdiContainer = this.MdiParent;
                if (mdiContainer != null)
                {
                    mdiContainer.Text = "Visor de imagenes - " + this.Text;
                }
            }
        }
        //guarda la imagen
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                string titulo = this.Text;
                if (titulo.StartsWith("Doc"))
                {
                    guardaComoToolStripMenuItem_Click(sender, e);
                }
                else
                {
                this.PictureBox.Refresh();
                string extension = Path.GetExtension(ruta);

                // Guardar la nueva imagen con la misma extensión que el archivo original
                switch (extension)
                {
                    case ".bmp":
                        PictureBox.Image.Save(ruta, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        PictureBox.Image.Save(ruta, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        PictureBox.Image.Save(ruta, ImageFormat.Png);
                        break;
                    default:
                        MessageBox.Show("Tipo de imagen no compatible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            
        }
        //guardar imagen
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem_Click(sender, e);
        }
        //ajustar imagen a la ventana hija
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ajustarVentanaToolStripMenuItem_Click(sender, e);
        }
        //añade texto a la imagen
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tAñadir_Click(sender, e);
        }
        //rota la imagen a 90 grados
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            tRotar_Click(sender, e);
        }
        //escala de grises
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            tEscalagrises_Click(sender, e);
        }
        public ToolStrip barraHerramientas
        {
            get { return toolStrip1; }
        }
        //rota la imagen 180 grados
        private void rotar180GradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = this.PictureBox.Image;
            if (image != null)
            {

                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                this.PictureBox.Refresh();
            }
        }

        
    }
}

