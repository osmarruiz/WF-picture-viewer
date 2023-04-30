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
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.tRotar = new System.Windows.Forms.ToolStripMenuItem();
            this.tAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.tEscalagrises = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardaComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(0, 37);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(701, 413);
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImagenAjustar,
            this.tRotar,
            this.tAñadir,
            this.tEscalagrises});
            this.imagenToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.imagenToolStripMenuItem.MergeIndex = 3;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // menuImagenAjustar
            // 
            this.menuImagenAjustar.Name = "menuImagenAjustar";
            this.menuImagenAjustar.Size = new System.Drawing.Size(198, 26);
            this.menuImagenAjustar.Text = "Ajustar Ventana";
            this.menuImagenAjustar.Click += new System.EventHandler(this.ajustarVentanaToolStripMenuItem_Click);
            // 
            // tRotar
            // 
            this.tRotar.Name = "tRotar";
            this.tRotar.Size = new System.Drawing.Size(198, 26);
            this.tRotar.Text = "Rotar 90 grados";
            this.tRotar.Click += new System.EventHandler(this.tRotar_Click);
            // 
            // tAñadir
            // 
            this.tAñadir.Name = "tAñadir";
            this.tAñadir.Size = new System.Drawing.Size(198, 26);
            this.tAñadir.Text = "Añadir texto";
            this.tAñadir.Click += new System.EventHandler(this.tAñadir_Click);
            // 
            // tEscalagrises
            // 
            this.tEscalagrises.Name = "tEscalagrises";
            this.tEscalagrises.Size = new System.Drawing.Size(198, 26);
            this.tEscalagrises.Text = "Escala de grises";
            this.tEscalagrises.Click += new System.EventHandler(this.tEscalagrises_Click);
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
            this.guardaComoToolStripMenuItem.Text = "Guarda como";
            this.guardaComoToolStripMenuItem.Click += new System.EventHandler(this.guardaComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 452);
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
    }
}