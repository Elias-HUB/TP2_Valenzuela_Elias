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
            menuListado.ShowDialog ();
        }

        private void CliclArticuloNuevo(object sender, EventArgs e)
        {
            MenuArticuloNuevo menuArticuloNuevo = new MenuArticuloNuevo();
            menuArticuloNuevo.ShowDialog();
        }

        private void ClickBuscar(object sender, EventArgs e)
        {
            MenuConsultaCriterioCodigo menuConsultaCriterioCodigo = new MenuConsultaCriterioCodigo();
            menuConsultaCriterioCodigo.ShowDialog();
        }

        private void ClickEliminar(object sender, EventArgs e)
        {
            MenuArticuloBorrar menuArticuloBorrar = new MenuArticuloBorrar();
            menuArticuloBorrar.ShowDialog();
        }

        private void CliclModificar(object sender, EventArgs e)
        {
            MenuArticuloModificar menuArticuloModificar = new MenuArticuloModificar();
            menuArticuloModificar.ShowDialog();
        }
    }
}
