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
        public bool ValidadorVentada = false;
        public MenuArticuloModificar padre;

        public MenuArticuloBorrar()
        {
            InitializeComponent();
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
                    TboxId.Text = Lista[0].ID.ToString();
                    TBoxNombre.Text = Lista[0].Nombre;
                    TBoxDescripcion.Text = Lista[0].Descripcion;
                    TboxMarca.Text = Lista[0].Marca.Descripcion;
                    TBoxCategoria.Text = Lista[0].Categoria.Descripcion;
                    TBoxPrecio.Text = (Lista[0].Precio).ToString("N2");
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
                TBoxNombre.Text = "";
                TBoxDescripcion.Text = "";
                TBoxCategoria.Text = "";
                TBoxCategoria.Text= "";
                TBoxPrecio.Text = "";
                PBoxArticulo.ImageLocation = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClickBorrar(object sender, EventArgs e)
        {
            try
            {
                if (TBoxCodigo.Text.Length > 0)
                {
                    DialogResult resul = MessageBox.Show("Seguro que desea eliminar el Articulo?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resul == DialogResult.Yes)
                    {
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        List<Articulo> Lista;
                        Lista = articuloNegocio.Buscar(TBoxCodigo.Text);
                        articuloNegocio.Eliminar(Lista[0].ID);
                        MessageBox.Show("El Articulo con Codigo " + TBoxCodigo.Text + " se elimino de manera correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Dispose();
                    }
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

        public void Busqueda(int ID)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo Art;
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Art = articuloNegocio.BuscarId(ID);
                TBoxCodigo.Text = Art.Codigo.ToString();
                TboxId.Text = Art.ID.ToString();
                TBoxNombre.Text = Art.Nombre;
                TBoxDescripcion.Text = Art.Descripcion;
                TboxMarca.Text = Art.Marca.Descripcion;
                TBoxCategoria.Text = Art.Categoria.Descripcion;
                TBoxPrecio.Text = (Art.Precio).ToString("N2");
                PBoxArticulo.ImageLocation = Art.Imagen;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CliclCancelar(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            try
            {
                ListadoBorrar listadoBorrar = new ListadoBorrar(this);
                listadoBorrar.ShowDialog();
                BtnBorrar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
