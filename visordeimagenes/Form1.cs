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
    public partial class VisorImagenes : Form
    {
        public VisorImagenes()
        {
            InitializeComponent();
        }


        private void tCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tMosaicoh_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tMosaicov_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tAcercade_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.MdiParent = this;
            a.Show();
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tNuevo_Click(object sender, EventArgs e)
        {
            string titulo = "Doc" + (this.MdiChildren.Length + 1);
            NuevaHija(titulo);
        }

        private void NuevaHija(string titulo)
        {
            VentanaHija hija = new VentanaHija(titulo);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
        }

        public VentanaHija VentanaHija { 
            get { return (VentanaHija)this.ActiveMdiChild;} 
        }

        private void tCerrar_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                this.VentanaHija.Close();
            }
        }

        private void tCargar_Click(object sender, EventArgs e)
        {

            this.VentanaHija.PictureBox.Image = Resource1.imagen;
        }
    }
}
