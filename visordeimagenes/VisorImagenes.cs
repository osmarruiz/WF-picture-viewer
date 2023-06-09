﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace visordeimagenes
{
    public partial class VisorImagenes : Form
    {
        public VisorImagenes()
        {
            InitializeComponent();

        }


        //ventanas hijas se ordenan en cascada
        private void tCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //orden en mosaico horizontal
        private void tMosaicoh_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        //orden en mosaico vertical
        private void tMosaicov_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        //crea el formulario acerca de
        private void tAcercade_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.MdiParent = this;
            a.Show();
        }
        //sale de la aplicacion
        private void tSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //crea una ventana hija
        private void tNuevo_Click(object sender, EventArgs e)
        {
            string titulo = "Doc" + (this.MdiChildren.Length + 1);
            NuevaHija(titulo);
        }
        //metodo de nueva hija
        private void NuevaHija(string titulo)
        {
            VentanaHija hija = new VentanaHija(titulo);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
            this.VentanaHija.PictureBox.Image = Resource1.imagen;
        }
        //metodo nueva hija con sobrecarga
        private void NuevaHija(string titulo, Image img)
        {
            VentanaHija hija = new VentanaHija(titulo);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
            this.VentanaHija.PictureBox.Image = img;
        }

        public VentanaHija VentanaHija {
            get { return (VentanaHija)this.ActiveMdiChild; }
        }
        //si hay una ventana hija la cierra
        private void tCerrar_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.VentanaHija.Close();
            }

        }
        //abrir imagenes desde el explorador
        private void tAbrir_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo OpenFileDialog 
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de imagen (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            dialogo.Title = "Seleccionar imagen";
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            AbrirArchivo(dialogo.FileName);


        }
        // metodo abrir imagenes
        private void AbrirArchivo(string ruta)
        {

            // Leer el contenido del archivo en un arreglo de bytes
            byte[] contenidoArchivo = File.ReadAllBytes(ruta);
            // Crear un flujo de memoria a partir del contenido del archivo
            using (MemoryStream ms = new MemoryStream(contenidoArchivo))
            {
                // Crear una imagen a partir del flujo
                Image imagen = Image.FromStream(ms);
                imagen = new Bitmap(imagen, new Size(imagen.Width, imagen.Height));
                string titulo = "Doc" + (this.MdiChildren.Length + 1);
                NuevaHija(titulo, imagen);
            }
        }
        // metodo que actualiza las opciones del menu
        private void actulizarmenu()
        {
            tCerrar.Enabled = this.ActiveMdiChild != null;
            tCopiar.Enabled = this.ActiveMdiChild != null;
            tCascada.Enabled = this.ActiveMdiChild != null;
            tMosaicov.Enabled = this.ActiveMdiChild != null;
            tMosaicoh.Enabled = this.ActiveMdiChild != null;

        }

       
        private void VisorImagenes_MdiChildActivate(object sender, EventArgs e)
        {
            actulizarmenu();
            ToolStripManager.RevertMerge(toolStrip1);
            VentanaHija ventanaHijaActiva = this.ActiveMdiChild as VentanaHija;
            if (ventanaHijaActiva != null)
                ToolStripManager.Merge(ventanaHijaActiva.barraHerramientas, toolStrip1);
        }

        
        private void VisorImagenes_Load(object sender, EventArgs e)
        {

            actulizarmenu();
        }
        //cuando se arastra la imagen en el formulario
        private void VisorImagenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos 
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.ToUpper().EndsWith(".JPG") &&
                 !file.ToUpper().EndsWith(".BMP") &&
                 !file.ToUpper().EndsWith(".GIF"))
                {
                    e.Effect = DragDropEffects.None; // Uno de los archivos no 
                                                     // es una imagen 
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes 
        }
        //cuando se suelta la imagen
        private void VisorImagenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                AbrirArchivo(file);
        }

        
        

        private void tVer_DropDownOpened(object sender, EventArgs e)
        {
            // Actualizar el estado de cada orden de menú según si la barra correspondiente está visible o no
            mostrarestado.Checked = statusStrip1.Visible;
            mostrarherramienta.Checked = toolStrip1.Visible;
        }

        private void mostrarBarraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar u ocultar la barra de estado según el estado actual del menú
            statusStrip1.Visible = !statusStrip1.Visible;

            // Actualizar el estado del menú según si la barra de estado está visible o no
            mostrarestado.Checked = statusStrip1.Visible;
        }

        private void mostrarBarraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar u ocultar la barra de herramientas según el estado actual del menú
            toolStrip1.Visible = !toolStrip1.Visible;

            // Actualizar el estado del menú según si la barra de herramientas está visible o no
            mostrarherramienta.Checked = toolStrip1.Visible;

        }
        //copia la imagen en portapapeles
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Image imagen = this.VentanaHija.PictureBox.Image;
            if (imagen != null)
            {
                Clipboard.SetImage(imagen);
            }
        }
        //pega la imagen del portapapeles
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject objeto = Clipboard.GetDataObject();
            if (objeto.GetDataPresent(DataFormats.Bitmap))
            {
                Image imagen = (Image)objeto.GetData(DataFormats.Bitmap);
                string titulo = "Doc" + (this.MdiChildren.Length + 1);
                NuevaHija(titulo, imagen);
            }
        }

        //nuevo
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tNuevo_Click(sender, e);
        }
        //abrir
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tAbrir_Click(sender, e);
        }
        // acerca de
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            tAcercade_Click(sender, e);
        }

        //etiqueta cambios al pasar el mouse
        private void tNuevo_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Crea una nueva ventana con una imagen predeterminada";
        }

        private void tNuevo_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void tSalir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cierra el programa";
        }

        private void tSalir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void tCerrar_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cierra una ventana con fotografia";
        }

        private void tCerrar_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void tAbrir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Abre una foto desde tu explorador";
        }

        private void tAbrir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void toolStripButton1_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Crea una nueva ventana con una imagen predeterminada";
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }
        private void toolStripButton2_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Abre una foto desde tu explorador";
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void toolStripButton8_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Informacion acerca de la aplicacion";

        }

        private void toolStripButton8_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

    }
}
