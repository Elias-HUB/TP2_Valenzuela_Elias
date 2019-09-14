using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> Listado = new List<Marca>();
            Marca MarcaAUX;

            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            try
            {
                Conexion.ConnectionString = "data source=.\\FRGP_PROG; initial catalog =CATALOGO_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select M.Id, M.Descripcion from MARCAS as M";
                Comando.Connection = Conexion;
                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    MarcaAUX = new Marca((int)Lector["Id"], (string)Lector["Descripcion"]);
                    Listado.Add(MarcaAUX);
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
