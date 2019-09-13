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
    public partial class MenuArticuloModificar : Menu
    {
        public MenuArticuloModificar()
        {
            InitializeComponent();
        }

        private void ClickCancelar(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ClickBuscar(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> Lista;
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (TBoxCodigo.Text.Length > 0)
                {
                    Lista = articuloNegocio.Buscar(TBoxCodigo.Text);
                    TBoxNombre.Text = Lista[0].Nombre;
                    TBoxDescripcion.Text = Lista[0].Descripcion;
                    CboxMarca.DataSource = marcaNegocio.Listar();
                    CboxCategoria.DataSource = categoriaNegocio.Listar();
                    CboxMarca.Text = Lista[0].Marca.Descripcion;
                    CboxCategoria.Text = Lista[0].Categoria.Descripcion;
                    TBoxPrecio.Text = Convert.ToString(Lista[0].Precio);
                    PBoxArticulo.ImageLocation = Lista[0].Imagen;
                    BtnAgregar.Enabled = true;
                    TBoxDescripcion.Enabled = true;
                    TBoxNombre.Enabled = true;
                    TBoxPrecio.Enabled = true;
                    TboxImagen.Enabled = true;
                    CboxCategoria.Enabled = true;
                    CboxMarca.Enabled = true;
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

        private void ClickAgregar(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List<Articulo> Lista;
                Articulo articulo = new Articulo();
                if (TBoxCodigo.Text.Length > 0)
                {
                    Lista = articuloNegocio.Buscar(TBoxCodigo.Text);
                    articulo.ID = (int)Lista[0].ID;
                    articulo.Codigo = TBoxCodigo.Text;
                    articulo.Nombre = TBoxNombre.Text;
                    articulo.Descripcion = TBoxDescripcion.Text;
                    articulo.Marca = (Marca)CboxMarca.SelectedItem;
                    articulo.Categoria = (Categoria)CboxCategoria.SelectedItem;
                    articulo.Imagen = TboxImagen.Text;
                    articulo.Precio = Convert.ToDecimal(TBoxPrecio.Text);
                    articuloNegocio.Modificar(articulo);
                    MessageBox.Show("El Articulo se modifico de manera correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    }
}
