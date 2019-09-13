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
    public partial class MenuConsultaCriterioCodigo : Menu
    {
        public MenuConsultaCriterioCodigo()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> Lista;
            try
            {
                if (TBoxCodigo.Text.Length > 0)
                {
                    Lista = articuloNegocio.Buscar(TBoxCodigo.Text);
                    TBoxNombre.Text = Lista[0].Nombre;
                    TBoxDescripcion.Text = Lista[0].Descripcion;
                    TboxMarca.Text = Lista[0].Marca.Descripcion;
                    TBoxCategoria.Text = Lista[0].Categoria.Descripcion;
                    TBoxPrecio.Text = Convert.ToString(Lista[0].Precio);
                    PBoxArticulo.ImageLocation = Lista[0].Imagen;
                }
                else
                {
                    MessageBox.Show(" Por favor ingrese un codigo ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(" El dato buscado " + TBoxCodigo.Text + " no existe \r\n" +
                "Por favor intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBoxCodigo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
