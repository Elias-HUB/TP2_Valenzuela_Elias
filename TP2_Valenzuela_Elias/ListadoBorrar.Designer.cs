namespace TP2_Valenzuela_Elias
{
    partial class ListadoBorrar
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
            this.TxtBusqueda = new System.Windows.Forms.Label();
            this.DGVConsulta = new System.Windows.Forms.DataGridView();
            this.TBoxBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.AutoSize = true;
            this.TxtBusqueda.Location = new System.Drawing.Point(259, 9);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(82, 20);
            this.TxtBusqueda.TabIndex = 4;
            this.TxtBusqueda.Text = "Busqueda";
            // 
            // DGVConsulta
            // 
            this.DGVConsulta.AllowUserToAddRows = false;
            this.DGVConsulta.AllowUserToDeleteRows = false;
            this.DGVConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGVConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVConsulta.Location = new System.Drawing.Point(12, 73);
            this.DGVConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVConsulta.MultiSelect = false;
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.ReadOnly = true;
            this.DGVConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConsulta.Size = new System.Drawing.Size(827, 385);
            this.DGVConsulta.TabIndex = 3;
            this.DGVConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seleccionar);
            // 
            // TBoxBusqueda
            // 
            this.TBoxBusqueda.Location = new System.Drawing.Point(144, 39);
            this.TBoxBusqueda.Name = "TBoxBusqueda";
            this.TBoxBusqueda.Size = new System.Drawing.Size(308, 26);
            this.TBoxBusqueda.TabIndex = 5;
            this.TBoxBusqueda.TextChanged += new System.EventHandler(this.TBoxBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doble Click para seleccionar";
            // 
            // ListadoBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoxBusqueda);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.DGVConsulta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListadoBorrar";
            this.Text = "Consulta de Articulos";
            this.Load += new System.EventHandler(this.MenuConsultaCriterioCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TxtBusqueda;
        private System.Windows.Forms.DataGridView DGVConsulta;
        private System.Windows.Forms.TextBox TBoxBusqueda;
        private System.Windows.Forms.Label label1;
    }
}