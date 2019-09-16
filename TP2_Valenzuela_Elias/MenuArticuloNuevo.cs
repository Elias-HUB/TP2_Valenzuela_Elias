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
    public partial class MenuArticuloNuevo : Menu
    {

        public MenuArticuloNuevo()
        {
            InitializeComponent();
        }

        private void MenuArticuloNuevo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                CboxMarca.DataSource = marcaNegocio.Listar();
                CboxCategoria.DataSource = categoriaNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void ClickCancelar(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                articulo.Codigo = TBoxCodigo.Text;
                articulo.Nombre = TBoxNombre.Text;
                articulo.Descripcion = TBoxDescripcion.Text;
                articulo.Marca = (Marca)CboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)CboxCategoria.SelectedItem;
                articulo.Imagen = TboxImagen.Text;
                articulo.Precio = Convert.ToDecimal(TBoxPrecio.Text);
                articuloNegocio.Agregar(articulo);
                MessageBox.Show("El Articulo se modifico de manera correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
