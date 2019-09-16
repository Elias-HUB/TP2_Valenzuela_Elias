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
        private List<Articulo> ArticuloGuardar;

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
                    TboxId.Text = Lista[0].ID.ToString();
                    TBoxNombre.Text = Lista[0].Nombre;
                    TBoxDescripcion.Text = Lista[0].Descripcion;
                    CboxMarca.DataSource = marcaNegocio.Listar();
                    CboxCategoria.DataSource = categoriaNegocio.Listar();
                    CboxMarca.Text = Lista[0].Marca.Descripcion;
                    CboxCategoria.Text = Lista[0].Categoria.Descripcion;
                    TBoxPrecio.Text = (Lista[0].Precio).ToString("N2");
                    PBoxArticulo.ImageLocation = Lista[0].Imagen;
                    TboxImagen.Text = Lista[0].Imagen;
                    ActivarCampos();
                    ArticuloGuardar = Lista;
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
                DesActivarCampos();
                TBoxNombre.Text = "";
                TBoxDescripcion.Text = "";
                CboxMarca.DataSource = null;
                CboxCategoria.DataSource = null;
                TBoxPrecio.Text = "";
                PBoxArticulo.ImageLocation = "";
                TboxImagen.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ActivarCampos()
        {
            BtnModificar.Enabled = true;
            TBoxDescripcion.Enabled = true;
            TBoxNombre.Enabled = true;
            TBoxPrecio.Enabled = true;
            TboxImagen.Enabled = true;
            CboxCategoria.Enabled = true;
            CboxMarca.Enabled = true;
        }

        public void DesActivarCampos()
        {
            BtnModificar.Enabled = false;
            TBoxDescripcion.Enabled = false;
            TBoxNombre.Enabled = false;
            TBoxPrecio.Enabled = false;
            TboxImagen.Enabled = false;
            CboxCategoria.Enabled = false;
            CboxMarca.Enabled = false;
        }

        private void ValNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Por Favor solo se aceptan Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void ValLetNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 32))
            {
                e.Handled = true;
                return;
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
                CboxMarca.DataSource = marcaNegocio.Listar();
                CboxCategoria.DataSource = categoriaNegocio.Listar();
                CboxMarca.Text = Art.Marca.Descripcion;
                CboxCategoria.Text = Art.Categoria.Descripcion;
                TBoxPrecio.Text = (Art.Precio).ToString("N2");
                PBoxArticulo.ImageLocation = Art.Imagen;
                TboxImagen.Text = Art.Imagen;
                ActivarCampos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void ClickModificar(object sender, EventArgs e)
        {
            try
            {

                    ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                    Articulo articulo = new Articulo();
                    if (TBoxCodigo.Text.Length > 0)
                    {
                        DialogResult resul = MessageBox.Show("Seguro que desea modificar el Articulo?", "Modificar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (resul == DialogResult.Yes)
                        {
                            articulo.ID = int.Parse(TboxId.Text);
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
                    }
                    else
                    {
                        MessageBox.Show(" Por favor ingrese un codigo, no puede quedar vacio!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ClickListado(object sender, EventArgs e)
        {
            MenuConsultaCriterioCodigo menuConsultaCriterioCodigo = new MenuConsultaCriterioCodigo(this);
            menuConsultaCriterioCodigo.ShowDialog();
        }
    }
}
