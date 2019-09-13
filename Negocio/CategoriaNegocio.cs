using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> Listado = new List<Categoria>();
            Categoria CatAUX;

            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            try
            {
                Conexion.ConnectionString = "data source=.\\FRGP_LABO; initial catalog =CATALOGO_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select M.Id, M.Descripcion from Categorias as M";
                Comando.Connection = Conexion;
                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatAUX = new Categoria((int)Lector["Id"], (string)Lector["Descripcion"]);
                    Listado.Add(CatAUX);
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
    }
}
