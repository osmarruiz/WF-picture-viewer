using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
