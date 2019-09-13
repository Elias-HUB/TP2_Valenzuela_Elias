namespace TP2_Valenzuela_Elias
{
    partial class MenuConsultaCriterioCodigo
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
            this.BtnCancelar = new System.Windows.Forms.Button();
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
            this.TboxMarca = new System.Windows.Forms.TextBox();
            this.TBoxCategoria = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(696, 251);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 36);
            this.BtnCancelar.TabIndex = 33;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TBoxCodigo
            // 
            this.TBoxCodigo.Location = new System.Drawing.Point(138, 25);
            this.TBoxCodigo.MaxLength = 10;
            this.TBoxCodigo.Name = "TBoxCodigo";
            this.TBoxCodigo.Size = new System.Drawing.Size(157, 26);
            this.TBoxCodigo.TabIndex = 25;
            // 
            // TBoxPrecio
            // 
            this.TBoxPrecio.Enabled = false;
            this.TBoxPrecio.Location = new System.Drawing.Point(138, 251);
            this.TBoxPrecio.MaxLength = 9;
            this.TBoxPrecio.Name = "TBoxPrecio";
            this.TBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.TBoxPrecio.TabIndex = 29;
            // 
            // TBoxDescripcion
            // 
            this.TBoxDescripcion.Enabled = false;
            this.TBoxDescripcion.Location = new System.Drawing.Point(138, 105);
            this.TBoxDescripcion.MaxLength = 74;
            this.TBoxDescripcion.Multiline = true;
            this.TBoxDescripcion.Name = "TBoxDescripcion";
            this.TBoxDescripcion.Size = new System.Drawing.Size(345, 55);
            this.TBoxDescripcion.TabIndex = 27;
            // 
            // TBoxNombre
            // 
            this.TBoxNombre.Enabled = false;
            this.TBoxNombre.Location = new System.Drawing.Point(138, 65);
            this.TBoxNombre.MaxLength = 15;
            this.TBoxNombre.Name = "TBoxNombre";
            this.TBoxNombre.Size = new System.Drawing.Size(157, 26);
            this.TBoxNombre.TabIndex = 26;
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Enabled = false;
            this.LblImagen.Location = new System.Drawing.Point(692, 171);
            this.LblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(63, 20);
            this.LblImagen.TabIndex = 23;
            this.LblImagen.Text = "Imagen";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Enabled = false;
            this.LblPrecio.Location = new System.Drawing.Point(21, 254);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(53, 20);
            this.LblPrecio.TabIndex = 22;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Enabled = false;
            this.LblCategoria.Location = new System.Drawing.Point(21, 214);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(78, 20);
            this.LblCategoria.TabIndex = 21;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Enabled = false;
            this.LblMarca.Location = new System.Drawing.Point(21, 174);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(53, 20);
            this.LblMarca.TabIndex = 20;
            this.LblMarca.Text = "Marca";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Enabled = false;
            this.LblDescripcion.Location = new System.Drawing.Point(21, 108);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 19;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Enabled = false;
            this.LblNombre.Location = new System.Drawing.Point(21, 68);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 18;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Enabled = false;
            this.LblCodigo.Location = new System.Drawing.Point(21, 28);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(59, 20);
            this.LblCodigo.TabIndex = 17;
            this.LblCodigo.Text = "Código";
            // 
            // TboxMarca
            // 
            this.TboxMarca.Enabled = false;
            this.TboxMarca.Location = new System.Drawing.Point(138, 171);
            this.TboxMarca.MaxLength = 15;
            this.TboxMarca.Name = "TboxMarca";
            this.TboxMarca.Size = new System.Drawing.Size(157, 26);
            this.TboxMarca.TabIndex = 34;
            // 
            // TBoxCategoria
            // 
            this.TBoxCategoria.Enabled = false;
            this.TBoxCategoria.Location = new System.Drawing.Point(138, 211);
            this.TBoxCategoria.MaxLength = 15;
            this.TBoxCategoria.Name = "TBoxCategoria";
            this.TBoxCategoria.Size = new System.Drawing.Size(157, 26);
            this.TBoxCategoria.TabIndex = 35;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(337, 20);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(83, 36);
            this.BtnBuscar.TabIndex = 32;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PBoxArticulo
            // 
            this.PBoxArticulo.Enabled = false;
            this.PBoxArticulo.Image = global::TP2_Valenzuela_Elias.Properties.Resources.NoLogo;
            this.PBoxArticulo.Location = new System.Drawing.Point(657, 20);
            this.PBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBoxArticulo.Name = "PBoxArticulo";
            this.PBoxArticulo.Size = new System.Drawing.Size(132, 132);
            this.PBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxArticulo.TabIndex = 24;
            this.PBoxArticulo.TabStop = false;
            // 
            // MenuConsultaCriterioCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 314);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuConsultaCriterioCodigo";
            this.Text = "MenuConsultaCriterioCodigo";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox TboxMarca;
        private System.Windows.Forms.TextBox TBoxCategoria;
    }
}