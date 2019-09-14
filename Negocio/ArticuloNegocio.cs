using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> Listado = new List<Articulo>();
            Articulo Aux;

            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            try
            {
                Conexion.ConnectionString = "data source=.\\FRGP_PROG; initial catalog =CATALOGO_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select a.Id, a.Codigo,a.Nombre,a.Descripcion,M.id, M.Descripcion, c.Id,  c.Descripcion, a.Imagen, a.Precio from ARTICULOS as A inner join MARCAS as M on a.IdMarca = M.Id inner join CATEGORIAS as c on a.IdMarca = c.Id";
                Comando.Connection = Conexion;
                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Lector.GetInt32(0);
                    Aux.Codigo = Lector.GetString(1);
                    Aux.Nombre = Lector.GetString(2);
                    Aux.Descripcion = Lector.GetString(3);
                    Aux.Marca= new Marca();
                    Aux.Marca.Id = Lector.GetInt32(4);
                    Aux.Marca.Descripcion = Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = Lector.GetInt32(6);
                    Aux.Categoria.Descripcion = Lector.GetString(7);
                    Aux.Imagen = Lector.GetString(8);
                    Aux.Precio = Lector.GetDecimal(9);
                    Listado.Add(Aux);
                }
                return Listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void Eliminar (int Id)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=.\\FRGP_PROG; initial catalog =CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "delete ARTICULOS where Id = '" + Id + "'";
                comando.Parameters.Clear();
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Modificar (Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=.\\FRGP_PROG; initial catalog =CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update ARTICULOS set Codigo = @Codigo where ID = '" + articulo.ID+ "';update ARTICULOS set Nombre = @Nombre where ID = '" + articulo.ID + "';update ARTICULOS set Descripcion = @Desc where ID = '" + articulo.ID + "';update ARTICULOS set IdMarca =@IdMarca where ID = '" + articulo.ID + "';update ARTICULOS set IdCategoria = @IdCategoria where ID = '" + articulo.ID + "';update ARTICULOS set Imagen = @Imagen where ID = '" + articulo.ID + "';update ARTICULOS set Precio = @Precio where ID = '" + articulo.ID + "'";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Desc", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.Id);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Id);
                comando.Parameters.AddWithValue("@Imagen", articulo.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Agregar (Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=.\\FRGP_PROG; initial catalog =CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into ARTICULOS values ( @Codigo,@Nombre, @Desc, @IdMarca, @IdCategoria, @Imagen, @Precio)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo",articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre",articulo.Nombre);
                comando.Parameters.AddWithValue("@Desc",articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca",articulo.Marca.Id);
                comando.Parameters.AddWithValue("@IdCategoria",articulo.Categoria.Id);
                comando.Parameters.AddWithValue("@Imagen",articulo.Imagen);
                comando.Parameters.AddWithValue("@Precio",articulo.Precio);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Articulo> Buscar (string busqueda)
        {
            List<Articulo> listado = new List<Articulo>();
            Articulo Aux;

            SqlCommand comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            try
            {
                Conexion.ConnectionString = "data source=.\\FRGP_PROG; initial catalog =CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select a.Id, a.Codigo,a.Nombre,a.Descripcion,(Select MARCAS.Id from MARCAS where MARCAS.Id = A.IdMarca) AS MarcaID,(Select MARCAS.Descripcion from MARCAS where MARCAS.Id = A.IdMarca)as MarcaDescripcion,(Select CATEGORIAS.Id from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaID,(Select CATEGORIAS.Descripcion from CATEGORIAS where CATEGORIAS.Id = A.IdMarca)as CategoriaDescripcion,a.Imagen, a.Precio from ARTICULOS as A where a.Codigo ='"+ busqueda+"'";
                comando.Connection = Conexion;

                Conexion.Open();
                Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Lector.GetInt32(0);
                    Aux.Codigo = Lector.GetString(1);
                    Aux.Nombre = Lector.GetString(2);
                    Aux.Descripcion = Lector.GetString(3);
                    Aux.Marca = new Marca();
                    Aux.Marca.Id = Lector.GetInt32(4);
                    Aux.Marca.Descripcion = Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = Lector.GetInt32(6);
                    Aux.Categoria.Descripcion = Lector.GetString(7);
                    Aux.Imagen = Lector.GetString(8);
                    Aux.Precio = Lector.GetDecimal(9);
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
                Conexion.Close();
            }
        }

    }
}
