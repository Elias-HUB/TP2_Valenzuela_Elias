namespace TP2_Valenzuela_Elias
{
    partial class MenuArticuloNuevo
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblImagen = new System.Windows.Forms.Label();
            this.TBoxCodigo = new System.Windows.Forms.TextBox();
            this.TBoxNombre = new System.Windows.Forms.TextBox();
            this.TBoxDescripcion = new System.Windows.Forms.TextBox();
            this.TboxImagen = new System.Windows.Forms.TextBox();
            this.TBoxPrecio = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboxCategoria = new System.Windows.Forms.ComboBox();
            this.CboxMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(79, 30);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(59, 20);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(79, 70);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(79, 110);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(79, 176);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(53, 20);
            this.LblMarca.TabIndex = 3;
            this.LblMarca.Text = "Marca";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(79, 214);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(78, 20);
            this.LblCategoria.TabIndex = 4;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(79, 252);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(53, 20);
            this.LblPrecio.TabIndex = 5;
            this.LblPrecio.Text = "Precio";
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(79, 290);
            this.LblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(102, 20);
            this.LblImagen.TabIndex = 6;
            this.LblImagen.Text = "Ruta Imagen";
            // 
            // TBoxCodigo
            // 
            this.TBoxCodigo.Location = new System.Drawing.Point(196, 27);
            this.TBoxCodigo.MaxLength = 10;
            this.TBoxCodigo.Name = "TBoxCodigo";
            this.TBoxCodigo.Size = new System.Drawing.Size(157, 26);
            this.TBoxCodigo.TabIndex = 8;
            this.TBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValLetNum);
            // 
            // TBoxNombre
            // 
            this.TBoxNombre.Location = new System.Drawing.Point(196, 67);
            this.TBoxNombre.MaxLength = 15;
            this.TBoxNombre.Name = "TBoxNombre";
            this.TBoxNombre.Size = new System.Drawing.Size(157, 26);
            this.TBoxNombre.TabIndex = 9;
            // 
            // TBoxDescripcion
            // 
            this.TBoxDescripcion.Location = new System.Drawing.Point(196, 107);
            this.TBoxDescripcion.MaxLength = 74;
            this.TBoxDescripcion.Multiline = true;
            this.TBoxDescripcion.Name = "TBoxDescripcion";
            this.TBoxDescripcion.Size = new System.Drawing.Size(345, 55);
            this.TBoxDescripcion.TabIndex = 10;
            // 
            // TboxImagen
            // 
            this.TboxImagen.Location = new System.Drawing.Point(196, 287);
            this.TboxImagen.MaxLength = 100;
            this.TboxImagen.Name = "TboxImagen";
            this.TboxImagen.Size = new System.Drawing.Size(284, 26);
            this.TboxImagen.TabIndex = 11;
            // 
            // TBoxPrecio
            // 
            this.TBoxPrecio.Location = new System.Drawing.Point(196, 249);
            this.TBoxPrecio.MaxLength = 9;
            this.TBoxPrecio.Name = "TBoxPrecio";
            this.TBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.TBoxPrecio.TabIndex = 12;
            this.TBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValNumeros);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(109, 340);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(87, 36);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(353, 340);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 36);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.ClickCancelar);
            // 
            // CboxCategoria
            // 
            this.CboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategoria.FormattingEnabled = true;
            this.CboxCategoria.Location = new System.Drawing.Point(196, 211);
            this.CboxCategoria.Name = "CboxCategoria";
            this.CboxCategoria.Size = new System.Drawing.Size(157, 28);
            this.CboxCategoria.TabIndex = 14;
            // 
            // CboxMarca
            // 
            this.CboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxMarca.FormattingEnabled = true;
            this.CboxMarca.Location = new System.Drawing.Point(196, 173);
            this.CboxMarca.Name = "CboxMarca";
            this.CboxMarca.Size = new System.Drawing.Size(157, 28);
            this.CboxMarca.TabIndex = 13;
            // 
            // MenuArticuloNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 388);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboxCategoria);
            this.Controls.Add(this.CboxMarca);
            this.Controls.Add(this.TBoxCodigo);
            this.Controls.Add(this.TBoxPrecio);
            this.Controls.Add(this.TboxImagen);
            this.Controls.Add(this.TBoxDescripcion);
            this.Controls.Add(this.TBoxNombre);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MenuArticuloNuevo";
            this.Text = "Alta de Articulo";
            this.Load += new System.EventHandler(this.MenuArticuloNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.TextBox TBoxCodigo;
        private System.Windows.Forms.TextBox TBoxNombre;
        private System.Windows.Forms.TextBox TBoxDescripcion;
        private System.Windows.Forms.TextBox TboxImagen;
        private System.Windows.Forms.TextBox TBoxPrecio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CboxCategoria;
        private System.Windows.Forms.ComboBox CboxMarca;
    }
}