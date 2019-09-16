namespace TP2_Valenzuela_Elias
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.TStripMenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.TStripBtnArticulo = new System.Windows.Forms.ToolStripDropDownButton();
            this.TStripBtnArticuloOpc1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TStripBtnArticuloOpc2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TStripBtnArticuloOpc3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TStripBtnListado = new System.Windows.Forms.ToolStripDropDownButton();
            this.TStripBtnListadoOpc1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TStripBtnConsulta = new System.Windows.Forms.ToolStripDropDownButton();
            this.TStripBtnConsultaOpc1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TStripMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TStripMenuPrincipal
            // 
            this.TStripMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.TStripMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStripBtnArticulo,
            this.toolStripSeparator1,
            this.TStripBtnListado,
            this.toolStripSeparator2,
            this.TStripBtnConsulta});
            this.TStripMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TStripMenuPrincipal.Name = "TStripMenuPrincipal";
            this.TStripMenuPrincipal.Size = new System.Drawing.Size(800, 25);
            this.TStripMenuPrincipal.TabIndex = 0;
            this.TStripMenuPrincipal.Text = "toolStrip1";
            // 
            // TStripBtnArticulo
            // 
            this.TStripBtnArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TStripBtnArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStripBtnArticuloOpc1,
            this.TStripBtnArticuloOpc2,
            this.TStripBtnArticuloOpc3});
            this.TStripBtnArticulo.Image = ((System.Drawing.Image)(resources.GetObject("TStripBtnArticulo.Image")));
            this.TStripBtnArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TStripBtnArticulo.Name = "TStripBtnArticulo";
            this.TStripBtnArticulo.Size = new System.Drawing.Size(62, 22);
            this.TStripBtnArticulo.Text = "Articulo";
            // 
            // TStripBtnArticuloOpc1
            // 
            this.TStripBtnArticuloOpc1.Image = global::TP2_Valenzuela_Elias.Properties.Resources.filenew;
            this.TStripBtnArticuloOpc1.Name = "TStripBtnArticuloOpc1";
            this.TStripBtnArticuloOpc1.Size = new System.Drawing.Size(125, 22);
            this.TStripBtnArticuloOpc1.Text = "Nuevo";
            this.TStripBtnArticuloOpc1.Click += new System.EventHandler(this.CliclArticuloNuevo);
            // 
            // TStripBtnArticuloOpc2
            // 
            this.TStripBtnArticuloOpc2.Image = global::TP2_Valenzuela_Elias.Properties.Resources.editar;
            this.TStripBtnArticuloOpc2.Name = "TStripBtnArticuloOpc2";
            this.TStripBtnArticuloOpc2.Size = new System.Drawing.Size(125, 22);
            this.TStripBtnArticuloOpc2.Text = "Modificar";
            this.TStripBtnArticuloOpc2.Click += new System.EventHandler(this.CliclModificar);
            // 
            // TStripBtnArticuloOpc3
            // 
            this.TStripBtnArticuloOpc3.Image = global::TP2_Valenzuela_Elias.Properties.Resources.delete;
            this.TStripBtnArticuloOpc3.Name = "TStripBtnArticuloOpc3";
            this.TStripBtnArticuloOpc3.Size = new System.Drawing.Size(125, 22);
            this.TStripBtnArticuloOpc3.Text = "Eliminar";
            this.TStripBtnArticuloOpc3.Click += new System.EventHandler(this.ClickEliminar);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TStripBtnListado
            // 
            this.TStripBtnListado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TStripBtnListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStripBtnListadoOpc1});
            this.TStripBtnListado.Image = ((System.Drawing.Image)(resources.GetObject("TStripBtnListado.Image")));
            this.TStripBtnListado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TStripBtnListado.Name = "TStripBtnListado";
            this.TStripBtnListado.Size = new System.Drawing.Size(63, 22);
            this.TStripBtnListado.Text = "Listados";
            // 
            // TStripBtnListadoOpc1
            // 
            this.TStripBtnListadoOpc1.Image = global::TP2_Valenzuela_Elias.Properties.Resources.new2;
            this.TStripBtnListadoOpc1.Name = "TStripBtnListadoOpc1";
            this.TStripBtnListadoOpc1.Size = new System.Drawing.Size(121, 22);
            this.TStripBtnListadoOpc1.Text = "Articulos";
            this.TStripBtnListadoOpc1.Click += new System.EventHandler(this.ClickListadosArt);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TStripBtnConsulta
            // 
            this.TStripBtnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.TStripBtnConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TStripBtnConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStripBtnConsultaOpc1});
            this.TStripBtnConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TStripBtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("TStripBtnConsulta.Image")));
            this.TStripBtnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TStripBtnConsulta.Name = "TStripBtnConsulta";
            this.TStripBtnConsulta.Size = new System.Drawing.Size(67, 22);
            this.TStripBtnConsulta.Text = "Consulta";
            // 
            // TStripBtnConsultaOpc1
            // 
            this.TStripBtnConsultaOpc1.Image = global::TP2_Valenzuela_Elias.Properties.Resources.editfind;
            this.TStripBtnConsultaOpc1.Name = "TStripBtnConsultaOpc1";
            this.TStripBtnConsultaOpc1.Size = new System.Drawing.Size(134, 22);
            this.TStripBtnConsultaOpc1.Text = "Por Criterio";
            this.TStripBtnConsultaOpc1.Click += new System.EventHandler(this.ClickConsultaCri);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TStripMenuPrincipal);
            this.Name = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TStripMenuPrincipal.ResumeLayout(false);
            this.TStripMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TStripMenuPrincipal;
        private System.Windows.Forms.ToolStripDropDownButton TStripBtnArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton TStripBtnListado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton TStripBtnConsulta;
        private System.Windows.Forms.ToolStripMenuItem TStripBtnArticuloOpc1;
        private System.Windows.Forms.ToolStripMenuItem TStripBtnArticuloOpc2;
        private System.Windows.Forms.ToolStripMenuItem TStripBtnArticuloOpc3;
        private System.Windows.Forms.ToolStripMenuItem TStripBtnListadoOpc1;
        private System.Windows.Forms.ToolStripMenuItem TStripBtnConsultaOpc1;
    }
}