namespace TP2_Valenzuela_Elias
{
    partial class MenuArticuloBorrar
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
            this.TBoxCategoria = new System.Windows.Forms.TextBox();
            this.TboxMarca = new System.Windows.Forms.TextBox();
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
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.PBoxArticulo = new System.Windows.Forms.PictureBox();
            this.TboxId = new System.Windows.Forms.TextBox();
            this.BtnListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // TBoxCategoria
            // 
            this.TBoxCategoria.Enabled = false;
            this.TBoxCategoria.Location = new System.Drawing.Point(131, 217);
            this.TBoxCategoria.MaxLength = 15;
            this.TBoxCategoria.Name = "TBoxCategoria";
            this.TBoxCategoria.Size = new System.Drawing.Size(157, 26);
            this.TBoxCategoria.TabIndex = 51;
            // 
            // TboxMarca
            // 
            this.TboxMarca.Enabled = false;
            this.TboxMarca.Location = new System.Drawing.Point(131, 177);
            this.TboxMarca.MaxLength = 15;
            this.TboxMarca.Name = "TboxMarca";
            this.TboxMarca.Size = new System.Drawing.Size(157, 26);
            this.TboxMarca.TabIndex = 50;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(689, 257);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 36);
            this.BtnCancelar.TabIndex = 49;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.CliclCancelar);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(330, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(83, 36);
            this.BtnBuscar.TabIndex = 48;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.ClickBuscar);
            // 
            // TBoxCodigo
            // 
            this.TBoxCodigo.Location = new System.Drawing.Point(131, 31);
            this.TBoxCodigo.MaxLength = 10;
            this.TBoxCodigo.Name = "TBoxCodigo";
            this.TBoxCodigo.Size = new System.Drawing.Size(157, 26);
            this.TBoxCodigo.TabIndex = 44;
            // 
            // TBoxPrecio
            // 
            this.TBoxPrecio.Enabled = false;
            this.TBoxPrecio.Location = new System.Drawing.Point(131, 257);
            this.TBoxPrecio.MaxLength = 9;
            this.TBoxPrecio.Name = "TBoxPrecio";
            this.TBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.TBoxPrecio.TabIndex = 47;
            // 
            // TBoxDescripcion
            // 
            this.TBoxDescripcion.Enabled = false;
            this.TBoxDescripcion.Location = new System.Drawing.Point(131, 111);
            this.TBoxDescripcion.MaxLength = 74;
            this.TBoxDescripcion.Multiline = true;
            this.TBoxDescripcion.Name = "TBoxDescripcion";
            this.TBoxDescripcion.Size = new System.Drawing.Size(345, 55);
            this.TBoxDescripcion.TabIndex = 46;
            // 
            // TBoxNombre
            // 
            this.TBoxNombre.Enabled = false;
            this.TBoxNombre.Location = new System.Drawing.Point(131, 71);
            this.TBoxNombre.MaxLength = 15;
            this.TBoxNombre.Name = "TBoxNombre";
            this.TBoxNombre.Size = new System.Drawing.Size(157, 26);
            this.TBoxNombre.TabIndex = 45;
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Enabled = false;
            this.LblImagen.Location = new System.Drawing.Point(628, 177);
            this.LblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(63, 20);
            this.LblImagen.TabIndex = 42;
            this.LblImagen.Text = "Imagen";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Enabled = false;
            this.LblPrecio.Location = new System.Drawing.Point(14, 260);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(53, 20);
            this.LblPrecio.TabIndex = 41;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Enabled = false;
            this.LblCategoria.Location = new System.Drawing.Point(14, 220);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(78, 20);
            this.LblCategoria.TabIndex = 40;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Enabled = false;
            this.LblMarca.Location = new System.Drawing.Point(14, 180);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(53, 20);
            this.LblMarca.TabIndex = 39;
            this.LblMarca.Text = "Marca";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Enabled = false;
            this.LblDescripcion.Location = new System.Drawing.Point(14, 114);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 38;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Enabled = false;
            this.LblNombre.Location = new System.Drawing.Point(14, 74);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 37;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Enabled = false;
            this.LblCodigo.Location = new System.Drawing.Point(14, 34);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(59, 20);
            this.LblCodigo.TabIndex = 36;
            this.LblCodigo.Text = "Código";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Enabled = false;
            this.BtnBorrar.Location = new System.Drawing.Point(567, 257);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(83, 36);
            this.BtnBorrar.TabIndex = 52;
            this.BtnBorrar.Text = "Eliminar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.ClickBorrar);
            // 
            // PBoxArticulo
            // 
            this.PBoxArticulo.Enabled = false;
            this.PBoxArticulo.ErrorImage = global::TP2_Valenzuela_Elias.Properties.Resources.NoLogo;
            this.PBoxArticulo.Image = global::TP2_Valenzuela_Elias.Properties.Resources.NoLogo;
            this.PBoxArticulo.Location = new System.Drawing.Point(598, 26);
            this.PBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBoxArticulo.Name = "PBoxArticulo";
            this.PBoxArticulo.Size = new System.Drawing.Size(132, 132);
            this.PBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxArticulo.TabIndex = 43;
            this.PBoxArticulo.TabStop = false;
            // 
            // TboxId
            // 
            this.TboxId.Location = new System.Drawing.Point(12, 292);
            this.TboxId.Name = "TboxId";
            this.TboxId.Size = new System.Drawing.Size(29, 26);
            this.TboxId.TabIndex = 76;
            this.TboxId.Visible = false;
            // 
            // BtnListado
            // 
            this.BtnListado.Location = new System.Drawing.Point(454, 26);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(83, 36);
            this.BtnListado.TabIndex = 75;
            this.BtnListado.Text = "Listado";
            this.BtnListado.UseVisualStyleBackColor = true;
            this.BtnListado.Click += new System.EventHandler(this.BtnListado_Click);
            // 
            // MenuArticuloBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.TboxId);
            this.Controls.Add(this.BtnListado);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.TBoxCategoria);
            this.Controls.Add(this.TboxMarca);
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
            this.Name = "MenuArticuloBorrar";
            this.Text = "Borrar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxCategoria;
        private System.Windows.Forms.TextBox TboxMarca;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TBoxCodigo;
        private System.Windows.Forms.TextBox TBoxPrecio;
        private System.Windows.Forms.TextBox TBoxDescripcion;
        private System.Windows.Forms.TextBox TBoxNombre;
        private System.Windows.Forms.PictureBox PBoxArticulo;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnBorrar;
        public System.Windows.Forms.TextBox TboxId;
        private System.Windows.Forms.Button BtnListado;
    }
}