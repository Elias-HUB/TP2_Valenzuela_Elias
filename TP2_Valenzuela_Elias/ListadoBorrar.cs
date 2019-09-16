using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_Valenzuela_Elias
{
    public partial class ListadoBorrar : Menu
    {
        private MenuArticuloBorrar padre;
        private List<Articulo> Lista;
        private List<Articulo> ListaAux;

        public ListadoBorrar()
        {
            InitializeComponent();
        }

        public ListadoBorrar(MenuArticuloBorrar Parametro)
        {
            InitializeComponent();
            padre = Parametro;
        }

        private void CargarDatos()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Lista = articuloNegocio.Listar();
                ListaAux = Lista;
                DGVConsulta.DataSource = Lista;
                DGVConsulta.Columns[0].Visible = false;
                DGVConsulta.Columns[6].Visible = false;
                DGVConsulta.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MenuConsultaCriterioCodigo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void TBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaFiltrada;
            try
            {
                if (TBoxBusqueda.Text.Length == 0)
                {
                    ListaFiltrada = Lista;
                }
                else
                {
                    ListaFiltrada = Lista.FindAll(B => B.Descripcion.ToLower().Contains(TBoxBusqueda.Text.ToLower()) || B.Codigo.ToLower().Contains(TBoxBusqueda.Text.ToLower()) || (B.Nombre.ToLower().Contains(TBoxBusqueda.Text.ToLower())));
                    ListaAux = ListaFiltrada;
                }
                DGVConsulta.DataSource = ListaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                padre.Busqueda(int.Parse(DGVConsulta.CurrentRow.Cells[0].Value.ToString()));
                Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
