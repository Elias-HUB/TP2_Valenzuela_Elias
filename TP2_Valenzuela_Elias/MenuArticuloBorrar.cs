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
    public partial class MenuArticuloBorrar : Menu
    {
        public MenuArticuloBorrar()
        {
            InitializeComponent();
        }

        private void ClickBuscar(object sender, EventArgs e)
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
                    BtnBorrar.Enabled = true;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clickBorrar(object sender, EventArgs e)
        {
            try
            {
                if (TBoxCodigo.Text.Length > 0)
                {
                    ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                    List<Articulo> Lista;
                    Lista = articuloNegocio.Buscar(TBoxCodigo.Text);
                    articuloNegocio.Eliminar(Lista[0].ID);
                    MessageBox.Show("El Articulo con Codigo " + TBoxCodigo.Text + " se elimino de manera correcta","", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Dispose();
                }
                else
                {
                    MessageBox.Show(" Por favor ingrese un codigo ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cliclCancelar(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
