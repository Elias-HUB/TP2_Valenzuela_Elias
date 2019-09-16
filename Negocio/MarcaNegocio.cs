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
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> Listado = new List<Marca>();
            Marca MarcaAUX;
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("Select M.Id, M.Descripcion from MARCAS as M");
                Datos.EjecutarLector();
                while (Datos.Lector.Read())
                {
                    MarcaAUX = new Marca((int)Datos.Lector["Id"], (string)Datos.Lector["Descripcion"]);
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
                Datos.CerrarConexion();
            }
        }
    }
}
