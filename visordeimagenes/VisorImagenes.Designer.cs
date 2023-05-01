namespace visordeimagenes
{
    partial class VisorImagenes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorImagenes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.tCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.tMosaicoh = new System.Windows.Forms.ToolStripMenuItem();
            this.tMosaicov = new System.Windows.Forms.ToolStripMenuItem();
            this.tAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mostrarestado = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarherramienta = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1068, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton1.MergeIndex = 0;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton1.MouseEnter += new System.EventHandler(this.toolStripButton1_MouseEnter);
            this.toolStripButton1.MouseLeave += new System.EventHandler(this.toolStripButton1_MouseLeave);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton2.MergeIndex = 1;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Abrir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.toolStripButton2.MouseEnter += new System.EventHandler(this.toolStripButton2_MouseEnter);
            this.toolStripButton2.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::visordeimagenes.Properties.Resources.acerca_de;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton8.MergeIndex = 9;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton8.Text = "Acerca de";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            this.toolStripButton8.MouseEnter += new System.EventHandler(this.toolStripButton8_MouseEnter);
            this.toolStripButton8.MouseLeave += new System.EventHandler(this.toolStripButton8_MouseLeave);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tArchivo,
            this.edicionToolStripMenuItem,
            this.tVer,
            this.tVentana,
            this.tAyuda});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.tVentana;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1068, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tArchivo
            // 
            this.tArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSalir,
            this.tCerrar,
            this.tNuevo,
            this.tAbrir});
            this.tArchivo.Name = "tArchivo";
            this.tArchivo.Size = new System.Drawing.Size(73, 24);
            this.tArchivo.Text = "Archivo";
            // 
            // tSalir
            // 
            this.tSalir.Name = "tSalir";
            this.tSalir.Size = new System.Drawing.Size(224, 26);
            this.tSalir.Text = "Salir";
            this.tSalir.Click += new System.EventHandler(this.tSalir_Click);
            this.tSalir.MouseEnter += new System.EventHandler(this.tSalir_MouseEnter);
            this.tSalir.MouseLeave += new System.EventHandler(this.tSalir_MouseLeave);
            // 
            // tCerrar
            // 
            this.tCerrar.Enabled = false;
            this.tCerrar.Name = "tCerrar";
            this.tCerrar.Size = new System.Drawing.Size(224, 26);
            this.tCerrar.Text = "Cerrar";
            this.tCerrar.Click += new System.EventHandler(this.tCerrar_Click);
            this.tCerrar.MouseEnter += new System.EventHandler(this.tCerrar_MouseEnter);
            this.tCerrar.MouseLeave += new System.EventHandler(this.tCerrar_MouseLeave);
            // 
            // tNuevo
            // 
            this.tNuevo.Name = "tNuevo";
            this.tNuevo.Size = new System.Drawing.Size(224, 26);
            this.tNuevo.Text = "Nuevo";
            this.tNuevo.Click += new System.EventHandler(this.tNuevo_Click);
            this.tNuevo.MouseEnter += new System.EventHandler(this.tNuevo_MouseEnter);
            this.tNuevo.MouseLeave += new System.EventHandler(this.tNuevo_MouseLeave);
            // 
            // tAbrir
            // 
            this.tAbrir.Name = "tAbrir";
            this.tAbrir.Size = new System.Drawing.Size(224, 26);
            this.tAbrir.Text = "Abrir";
            this.tAbrir.Click += new System.EventHandler(this.tAbrir_Click);
            this.tAbrir.MouseEnter += new System.EventHandler(this.tAbrir_MouseEnter);
            this.tAbrir.MouseLeave += new System.EventHandler(this.tAbrir_MouseLeave);
            // 
            // tVer
            // 
            this.tVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarestado,
            this.mostrarherramienta});
            this.tVer.Name = "tVer";
            this.tVer.Size = new System.Drawing.Size(44, 24);
            this.tVer.Text = "Ver";
            this.tVer.DropDownOpened += new System.EventHandler(this.tVer_DropDownOpened);
            // 
            // tVentana
            // 
            this.tVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCascada,
            this.tMosaicoh,
            this.tMosaicov});
            this.tVentana.Name = "tVentana";
            this.tVentana.Size = new System.Drawing.Size(76, 24);
            this.tVentana.Text = "Ventana";
            // 
            // tCascada
            // 
            this.tCascada.Enabled = false;
            this.tCascada.Name = "tCascada";
            this.tCascada.Size = new System.Drawing.Size(224, 26);
            this.tCascada.Text = "Cascada";
            this.tCascada.Click += new System.EventHandler(this.tCascada_Click);
            // 
            // tMosaicoh
            // 
            this.tMosaicoh.Enabled = false;
            this.tMosaicoh.Name = "tMosaicoh";
            this.tMosaicoh.Size = new System.Drawing.Size(224, 26);
            this.tMosaicoh.Text = "Mosaico Horizontal";
            this.tMosaicoh.Click += new System.EventHandler(this.tMosaicoh_Click);
            // 
            // tMosaicov
            // 
            this.tMosaicov.Enabled = false;
            this.tMosaicov.Name = "tMosaicov";
            this.tMosaicov.Size = new System.Drawing.Size(224, 26);
            this.tMosaicov.Text = "Mosaico Vertical";
            this.tMosaicov.Click += new System.EventHandler(this.tMosaicov_Click);
            // 
            // tAyuda
            // 
            this.tAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAcercade});
            this.tAyuda.Name = "tAyuda";
            this.tAyuda.Size = new System.Drawing.Size(65, 24);
            this.tAyuda.Text = "Ayuda";
            // 
            // tAcercade
            // 
            this.tAcercade.Name = "tAcercade";
            this.tAcercade.Size = new System.Drawing.Size(224, 26);
            this.tAcercade.Text = "Acerca de";
            this.tAcercade.Click += new System.EventHandler(this.tAcercade_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1068, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 8;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(87, 20);
            this.etiquetaEstado.Text = "Bienvenido!";
            // 
            // mostrarestado
            // 
            this.mostrarestado.Name = "mostrarestado";
            this.mostrarestado.Size = new System.Drawing.Size(355, 26);
            this.mostrarestado.Text = "Mostrar / Ocultar barra de estado";
            this.mostrarestado.Click += new System.EventHandler(this.mostrarBarraDeEstadoToolStripMenuItem_Click);
            // 
            // mostrarherramienta
            // 
            this.mostrarherramienta.Name = "mostrarherramienta";
            this.mostrarherramienta.Size = new System.Drawing.Size(355, 26);
            this.mostrarherramienta.Text = "Mostrar / Ocultar barra de herramientas";
            this.mostrarherramienta.Click += new System.EventHandler(this.mostrarBarraDeHerramientasToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCopiar,
            this.tPegar});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // tCopiar
            // 
            this.tCopiar.Enabled = false;
            this.tCopiar.Name = "tCopiar";
            this.tCopiar.Size = new System.Drawing.Size(224, 26);
            this.tCopiar.Text = "Copiar";
            this.tCopiar.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // tPegar
            // 
            this.tPegar.Name = "tPegar";
            this.tPegar.Size = new System.Drawing.Size(224, 26);
            this.tPegar.Text = "Pegar";
            this.tPegar.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // VisorImagenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 636);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "VisorImagenes";
            this.Text = "Visor de imagenes";
            this.Load += new System.EventHandler(this.VisorImagenes_Load);
            this.MdiChildActivate += new System.EventHandler(this.VisorImagenes_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VisorImagenes_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VisorImagenes_DragEnter);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tArchivo;
        private System.Windows.Forms.ToolStripMenuItem tVer;
        private System.Windows.Forms.ToolStripMenuItem tVentana;
        private System.Windows.Forms.ToolStripMenuItem tAyuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tCascada;
        private System.Windows.Forms.ToolStripMenuItem tMosaicoh;
        private System.Windows.Forms.ToolStripMenuItem tMosaicov;
        private System.Windows.Forms.ToolStripMenuItem tAcercade;
        private System.Windows.Forms.ToolStripMenuItem tSalir;
        private System.Windows.Forms.ToolStripMenuItem tCerrar;
        private System.Windows.Forms.ToolStripMenuItem tNuevo;
        private System.Windows.Forms.ToolStripMenuItem tAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
        private System.Windows.Forms.ToolStripMenuItem mostrarestado;
        private System.Windows.Forms.ToolStripMenuItem mostrarherramienta;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCopiar;
        private System.Windows.Forms.ToolStripMenuItem tPegar;
    }
}

