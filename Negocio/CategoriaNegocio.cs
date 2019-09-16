using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Data.SqlClient;


namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> Listado = new List<Categoria>();
            Categoria CatAUX;
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("Select M.Id, M.Descripcion from Categorias as M");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    CatAUX = new Categoria((int)Datos.Lector["Id"], (string)Datos.Lector["Descripcion"]);
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
                Datos.CerrarConexion();
            }
        }
    }
}
