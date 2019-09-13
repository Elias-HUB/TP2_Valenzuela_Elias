using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Valenzuela_Elias
{
    public partial class MenuPrincipal : Menu
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ClickListadosArt(object sender, EventArgs e)
        {
            MenuListado menuListado = new MenuListado();
            menuListado.Show();
        }

        private void CliclArticuloNuevo(object sender, EventArgs e)
        {
            MenuArticuloNuevo menuArticuloNuevo = new MenuArticuloNuevo();
            menuArticuloNuevo.Show();
        }
    }
}
