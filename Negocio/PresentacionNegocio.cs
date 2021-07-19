using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;


namespace Negocio
{
    public class PresentacionNegocio
    {
        public List<Presentacion> listar()
        {
            List<Presentacion> lista = new List<Presentacion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID,DESCRIPCION from Presentacion");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Presentacion aux = new Presentacion();
                    aux.id = (int)datos.Lector["ID"];
                    aux.descripcion = (string)datos.Lector["DESCRIPCION"];
                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

