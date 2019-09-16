using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> listado = new List<Articulo>();
            Articulo Aux;
            string Auxiliar;
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("Select a.Id, a.Codigo,a.Nombre,a.Descripcion,(Select MARCAS.Id from MARCAS where MARCAS.Id = A.IdMarca) AS MarcaID,(Select MARCAS.Descripcion from MARCAS where MARCAS.Id = A.IdMarca)as MarcaDescripcion,(Select CATEGORIAS.Id from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaID,(Select CATEGORIAS.Descripcion from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaDescripcion,a.Imagen, a.Precio from ARTICULOS as A where Borrado = 0 ");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Codigo = Datos.Lector.GetString(1);
                    Aux.Nombre = Datos.Lector.GetString(2);
                    Aux.Descripcion = Datos.Lector.GetString(3);
                    Aux.Marca= new Marca();
                    Aux.Marca.Id = Datos.Lector.GetInt32(4);
                    Aux.Marca.Descripcion = Datos.Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = Datos.Lector.GetInt32(6);
                    Aux.Categoria.Descripcion = Datos.Lector.GetString(7);
                    Aux.Imagen = Datos.Lector.GetString(8);
                    Auxiliar = Datos.Lector.GetDecimal(9).ToString("N2");
                    Aux.Precio = Decimal.Parse(Auxiliar);
                    listado.Add(Aux);
                }
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public void Eliminar (int Id)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("update ARTICULOS set Borrado = 1 where id = '" + Id + "'");
                Datos.Clear();
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar (Articulo articulo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("update ARTICULOS set Codigo = @Codigo where ID = @Id;update ARTICULOS set Nombre = @Nombre where ID = @Id;update ARTICULOS set Descripcion = @Desc where ID = @Id;update ARTICULOS set IdMarca =@IdMarca where ID = @Id;update ARTICULOS set IdCategoria = @IdCategoria where ID = @Id;update ARTICULOS set Imagen = @Imagen where ID = @Id;update ARTICULOS set Precio = @Precio where ID = @Id");
                Datos.Clear();
                Datos.agregarParametro("@Id", articulo.ID);
                Datos.agregarParametro("@Codigo", articulo.Codigo);
                Datos.agregarParametro("@Nombre", articulo.Nombre);
                Datos.agregarParametro("@Desc", articulo.Descripcion);
                Datos.agregarParametro("@IdMarca", articulo.Marca.Id);
                Datos.agregarParametro("@IdCategoria", articulo.Categoria.Id);
                Datos.agregarParametro("@Imagen", articulo.Imagen);
                Datos.agregarParametro("@Precio", articulo.Precio);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Agregar (Articulo articulo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery ("Insert into ARTICULOS values ( @Codigo,@Nombre, @Desc, @IdMarca, @IdCategoria, @Imagen, @Precio,@Borrado)");
                Datos.Clear();
                Datos.agregarParametro("@Codigo",articulo.Codigo);
                Datos.agregarParametro("@Nombre",articulo.Nombre);
                Datos.agregarParametro("@Desc",articulo.Descripcion);
                Datos.agregarParametro("@IdMarca",articulo.Marca.Id);
                Datos.agregarParametro("@IdCategoria",articulo.Categoria.Id);
                Datos.agregarParametro("@Imagen",articulo.Imagen);
                Datos.agregarParametro("@Precio",articulo.Precio);
                Datos.agregarParametro("@Borrado", 0);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Articulo BuscarId (int ID)
        {
            Articulo Aux = null;
            string Auxiliar;
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("Select a.Id, a.Codigo, a.Nombre, a.Descripcion, (Select MARCAS.Id from MARCAS where MARCAS.Id = A.IdMarca) AS MarcaID,(Select MARCAS.Descripcion from MARCAS where MARCAS.Id = A.IdMarca)as MarcaDescripcion,(Select CATEGORIAS.Id from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaID,(Select CATEGORIAS.Descripcion from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaDescripcion,a.Imagen, a.Precio from ARTICULOS as A where Borrado = 0 and a.Id = " + ID + "");
                Datos.EjecutarLector();
                while (Datos.Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Codigo = Datos.Lector.GetString(1);
                    Aux.Nombre = Datos.Lector.GetString(2);
                    Aux.Descripcion = Datos.Lector.GetString(3);
                    Aux.Marca = new Marca();
                    Aux.Marca.Id = Datos.Lector.GetInt32(4);
                    Aux.Marca.Descripcion = Datos.Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = Datos.Lector.GetInt32(6);
                    Aux.Categoria.Descripcion = Datos.Lector.GetString(7);
                    Aux.Imagen = Datos.Lector.GetString(8);
                    Auxiliar = Datos.Lector.GetDecimal(9).ToString("N2");
                    Aux.Precio = Decimal.Parse(Auxiliar);

                }
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public List<Articulo> Buscar(string busqueda)
        {
            List<Articulo> listado = new List<Articulo>();
            Articulo Aux;
            string Auxiliar;

            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("Select a.Id, a.Codigo,a.Nombre,a.Descripcion,(Select MARCAS.Id from MARCAS where MARCAS.Id = A.IdMarca) AS MarcaID,(Select MARCAS.Descripcion from MARCAS where MARCAS.Id = A.IdMarca)as MarcaDescripcion,(Select CATEGORIAS.Id from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaID,(Select CATEGORIAS.Descripcion from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaDescripcion,a.Imagen, a.Precio from ARTICULOS as A where Borrado = 0 and  a.Codigo ='" + busqueda + "'");
                Datos.EjecutarLector();
                while (Datos.Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Codigo = Datos.Lector.GetString(1);
                    Aux.Nombre = Datos.Lector.GetString(2);
                    Aux.Descripcion = Datos.Lector.GetString(3);
                    Aux.Marca = new Marca();
                    Aux.Marca.Id = Datos.Lector.GetInt32(4);
                    Aux.Marca.Descripcion = Datos.Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = Datos.Lector.GetInt32(6);
                    Aux.Categoria.Descripcion = Datos.Lector.GetString(7);
                    Aux.Imagen = Datos.Lector.GetString(8);
                    Auxiliar = Datos.Lector.GetDecimal(9).ToString("N2");
                    Aux.Precio = Decimal.Parse(Auxiliar);
                    listado.Add(Aux);
                }
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

    }
}



