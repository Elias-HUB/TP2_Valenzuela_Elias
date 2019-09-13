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

namespace TP2_Valenzuela_Elias
{
    public partial class MenuArticuloNuevo : Menu
    {
        public MenuArticuloNuevo()
        {
            InitializeComponent();
        }

        private void MenuArticuloNuevo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                CboxMarca.DataSource = marcaNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
