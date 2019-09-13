using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP2_Valenzuela_Elias
{
    public partial class MenuListado : Menu
    {
        public MenuListado()
        {
            InitializeComponent();
        }

        private void MenuListado_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> Lista;
            try
            {
                Lista = articuloNegocio.Listar();
                DGVMenuListado.DataSource= Lista;
                DGVMenuListado.Columns[0].Visible = false;
                DGVMenuListado.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
