namespace visordeimagenes
{
    partial class VentanaHija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardaComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.tRotar = new System.Windows.Forms.ToolStripMenuItem();
            this.rotar180GradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.tEscalagrises = new System.Windows.Forms.ToolStripMenuItem();
            this.EscalaRojos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.EscalaAzules = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(0, 1);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(701, 449);
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.imagenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.guardaComoToolStripMenuItem,
            this.toolStripSeparator1});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarToolStripMenuItem.MergeIndex = 3;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardaComoToolStripMenuItem
            // 
            this.guardaComoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardaComoToolStripMenuItem.MergeIndex = 4;
            this.guardaComoToolStripMenuItem.Name = "guardaComoToolStripMenuItem";
            this.guardaComoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardaComoToolStripMenuItem.Text = "Guardar como";
            this.guardaComoToolStripMenuItem.Click += new System.EventHandler(this.guardaComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImagenAjustar,
            this.tRotar,
            this.rotar180GradosToolStripMenuItem,
            this.tAñadir,
            this.tEscalagrises,
            this.EscalaRojos,
            this.EscalaAzules});
            this.imagenToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.imagenToolStripMenuItem.MergeIndex = 3;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // menuImagenAjustar
            // 
            this.menuImagenAjustar.Name = "menuImagenAjustar";
            this.menuImagenAjustar.Size = new System.Drawing.Size(224, 26);
            this.menuImagenAjustar.Text = "Ajustar Ventana";
            this.menuImagenAjustar.Click += new System.EventHandler(this.ajustarVentanaToolStripMenuItem_Click);
            // 
            // tRotar
            // 
            this.tRotar.Name = "tRotar";
            this.tRotar.Size = new System.Drawing.Size(224, 26);
            this.tRotar.Text = "Rotar 90 grados";
            this.tRotar.Click += new System.EventHandler(this.tRotar_Click);
            // 
            // rotar180GradosToolStripMenuItem
            // 
            this.rotar180GradosToolStripMenuItem.Name = "rotar180GradosToolStripMenuItem";
            this.rotar180GradosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rotar180GradosToolStripMenuItem.Text = "Rotar 180 grados";
            this.rotar180GradosToolStripMenuItem.Click += new System.EventHandler(this.rotar180GradosToolStripMenuItem_Click);
            // 
            // tAñadir
            // 
            this.tAñadir.Name = "tAñadir";
            this.tAñadir.Size = new System.Drawing.Size(224, 26);
            this.tAñadir.Text = "Añadir texto";
            this.tAñadir.Click += new System.EventHandler(this.tAñadir_Click);
            // 
            // tEscalagrises
            // 
            this.tEscalagrises.Name = "tEscalagrises";
            this.tEscalagrises.Size = new System.Drawing.Size(224, 26);
            this.tEscalagrises.Text = "Escala de grises";
            this.tEscalagrises.Click += new System.EventHandler(this.tEscalagrises_Click);
            // 
            // EscalaRojos
            // 
            this.EscalaRojos.Name = "EscalaRojos";
            this.EscalaRojos.Size = new System.Drawing.Size(224, 26);
            this.EscalaRojos.Text = "Escala de rojos";
            this.EscalaRojos.Click += new System.EventHandler(this.EscalaRojos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::visordeimagenes.Properties.Resources.guardar_el_archivo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton1.MergeIndex = 2;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator2.MergeIndex = 3;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::visordeimagenes.Properties.Resources.minimizar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton2.MergeIndex = 4;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Ajustar imagen";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::visordeimagenes.Properties.Resources.insertar_icono_de_imagen;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton5.MergeIndex = 5;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Escala de grises";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::visordeimagenes.Properties.Resources.imagen__1_;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton4.MergeIndex = 6;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Rotar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::visordeimagenes.Properties.Resources.fuente;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton3.MergeIndex = 7;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Texto";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // EscalaAzules
            // 
            this.EscalaAzules.Name = "EscalaAzules";
            this.EscalaAzules.Size = new System.Drawing.Size(224, 26);
            this.EscalaAzules.Text = "Escala de azules";
            this.EscalaAzules.Click += new System.EventHandler(this.EscalaAzules_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 452);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaHija";
            this.Text = "VentanaHija";
            this.Activated += new System.EventHandler(this.VentanaHija_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaHija_FormClosing);
            this.Load += new System.EventHandler(this.VentanaHija_Load);
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImagenAjustar;
        private System.Windows.Forms.ToolStripMenuItem tRotar;
        private System.Windows.Forms.ToolStripMenuItem tAñadir;
        private System.Windows.Forms.ToolStripMenuItem tEscalagrises;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardaComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem rotar180GradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EscalaRojos;
        private System.Windows.Forms.ToolStripMenuItem EscalaAzules;
    }
}