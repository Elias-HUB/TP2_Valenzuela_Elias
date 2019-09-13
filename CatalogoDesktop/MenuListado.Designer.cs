namespace TP2_Valenzuela_Elias
{
    partial class MenuListado
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
            this.DGVMenuListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenuListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMenuListado
            // 
            this.DGVMenuListado.BackgroundColor = System.Drawing.Color.White;
            this.DGVMenuListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMenuListado.Location = new System.Drawing.Point(-1, -3);
            this.DGVMenuListado.Name = "DGVMenuListado";
            this.DGVMenuListado.Size = new System.Drawing.Size(802, 280);
            this.DGVMenuListado.TabIndex = 0;
            // 
            // MenuListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.DGVMenuListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuListado";
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.MenuListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenuListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMenuListado;
    }
}