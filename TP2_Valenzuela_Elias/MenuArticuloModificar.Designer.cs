namespace TP2_Valenzuela_Elias
{
    partial class MenuArticuloModificar
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TBoxCodigo = new System.Windows.Forms.TextBox();
            this.TBoxPrecio = new System.Windows.Forms.TextBox();
            this.TBoxDescripcion = new System.Windows.Forms.TextBox();
            this.TBoxNombre = new System.Windows.Forms.TextBox();
            this.LblImagen = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.PBoxArticulo = new System.Windows.Forms.PictureBox();
            this.TboxImagen = new System.Windows.Forms.TextBox();
            this.CboxCategoria = new System.Windows.Forms.ComboBox();
            this.CboxMarca = new System.Windows.Forms.ComboBox();
            this.BtnListado = new System.Windows.Forms.Button();
            this.TboxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Location = new System.Drawing.Point(536, 250);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(83, 36);
            this.BtnModificar.TabIndex = 69;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.ClickModificar);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(667, 250);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 36);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.ClickCancelar);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(314, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(83, 36);
            this.BtnBuscar.TabIndex = 65;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.ClickBuscar);
            // 
            // TBoxCodigo
            // 
            this.TBoxCodigo.Location = new System.Drawing.Point(140, 24);
            this.TBoxCodigo.MaxLength = 10;
            this.TBoxCodigo.Name = "TBoxCodigo";
            this.TBoxCodigo.Size = new System.Drawing.Size(157, 26);
            this.TBoxCodigo.TabIndex = 61;
            this.TBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValLetNum);
            // 
            // TBoxPrecio
            // 
            this.TBoxPrecio.Enabled = false;
            this.TBoxPrecio.Location = new System.Drawing.Point(140, 250);
            this.TBoxPrecio.MaxLength = 9;
            this.TBoxPrecio.Name = "TBoxPrecio";
            this.TBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.TBoxPrecio.TabIndex = 64;
            this.TBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValNumeros);
            // 
            // TBoxDescripcion
            // 
            this.TBoxDescripcion.Enabled = false;
            this.TBoxDescripcion.Location = new System.Drawing.Point(140, 104);
            this.TBoxDescripcion.MaxLength = 74;
            this.TBoxDescripcion.Multiline = true;
            this.TBoxDescripcion.Name = "TBoxDescripcion";
            this.TBoxDescripcion.Size = new System.Drawing.Size(345, 55);
            this.TBoxDescripcion.TabIndex = 63;
            // 
            // TBoxNombre
            // 
            this.TBoxNombre.Enabled = false;
            this.TBoxNombre.Location = new System.Drawing.Point(140, 64);
            this.TBoxNombre.MaxLength = 15;
            this.TBoxNombre.Name = "TBoxNombre";
            this.TBoxNombre.Size = new System.Drawing.Size(157, 26);
            this.TBoxNombre.TabIndex = 62;
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(597, 170);
            this.LblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(102, 20);
            this.LblImagen.TabIndex = 59;
            this.LblImagen.Text = "Ruta Imagen";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(23, 253);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(53, 20);
            this.LblPrecio.TabIndex = 58;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(23, 213);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(78, 20);
            this.LblCategoria.TabIndex = 57;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(23, 173);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(53, 20);
            this.LblMarca.TabIndex = 56;
            this.LblMarca.Text = "Marca";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(23, 107);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 55;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(23, 67);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 54;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Enabled = false;
            this.LblCodigo.Location = new System.Drawing.Point(23, 27);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(59, 20);
            this.LblCodigo.TabIndex = 53;
            this.LblCodigo.Text = "Código";
            // 
            // PBoxArticulo
            // 
            this.PBoxArticulo.ErrorImage = global::TP2_Valenzuela_Elias.Properties.Resources.NoLogo;
            this.PBoxArticulo.Image = global::TP2_Valenzuela_Elias.Properties.Resources.NoLogo;
            this.PBoxArticulo.Location = new System.Drawing.Point(583, 19);
            this.PBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBoxArticulo.Name = "PBoxArticulo";
            this.PBoxArticulo.Size = new System.Drawing.Size(132, 132);
            this.PBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxArticulo.TabIndex = 60;
            this.PBoxArticulo.TabStop = false;
            // 
            // TboxImagen
            // 
            this.TboxImagen.Enabled = false;
            this.TboxImagen.Location = new System.Drawing.Point(499, 193);
            this.TboxImagen.MaxLength = 70;
            this.TboxImagen.Name = "TboxImagen";
            this.TboxImagen.Size = new System.Drawing.Size(289, 26);
            this.TboxImagen.TabIndex = 70;
            // 
            // CboxCategoria
            // 
            this.CboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategoria.Enabled = false;
            this.CboxCategoria.FormattingEnabled = true;
            this.CboxCategoria.Location = new System.Drawing.Point(140, 210);
            this.CboxCategoria.Name = "CboxCategoria";
            this.CboxCategoria.Size = new System.Drawing.Size(157, 28);
            this.CboxCategoria.TabIndex = 72;
            // 
            // CboxMarca
            // 
            this.CboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxMarca.Enabled = false;
            this.CboxMarca.FormattingEnabled = true;
            this.CboxMarca.Location = new System.Drawing.Point(140, 170);
            this.CboxMarca.Name = "CboxMarca";
            this.CboxMarca.Size = new System.Drawing.Size(157, 28);
            this.CboxMarca.TabIndex = 71;
            // 
            // BtnListado
            // 
            this.BtnListado.Location = new System.Drawing.Point(417, 19);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(83, 36);
            this.BtnListado.TabIndex = 73;
            this.BtnListado.Text = "Listado";
            this.BtnListado.UseVisualStyleBackColor = true;
            this.BtnListado.Click += new System.EventHandler(this.ClickListado);
            // 
            // TboxId
            // 
            this.TboxId.Location = new System.Drawing.Point(2, 288);
            this.TboxId.Name = "TboxId";
            this.TboxId.Size = new System.Drawing.Size(29, 26);
            this.TboxId.TabIndex = 74;
            this.TboxId.Visible = false;
            // 
            // MenuArticuloModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.TboxId);
            this.Controls.Add(this.BtnListado);
            this.Controls.Add(this.CboxCategoria);
            this.Controls.Add(this.CboxMarca);
            this.Controls.Add(this.TboxImagen);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TBoxCodigo);
            this.Controls.Add(this.TBoxPrecio);
            this.Controls.Add(this.TBoxDescripcion);
            this.Controls.Add(this.TBoxNombre);
            this.Controls.Add(this.PBoxArticulo);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MenuArticuloModificar";
            this.Text = "Modificar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox PBoxArticulo;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnListado;
        public System.Windows.Forms.TextBox TBoxCodigo;
        public System.Windows.Forms.TextBox TBoxPrecio;
        public System.Windows.Forms.TextBox TBoxDescripcion;
        public System.Windows.Forms.TextBox TBoxNombre;
        public System.Windows.Forms.TextBox TboxImagen;
        public System.Windows.Forms.ComboBox CboxCategoria;
        public System.Windows.Forms.ComboBox CboxMarca;
        public System.Windows.Forms.TextBox TboxId;
    }
}