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




        public List<Presentacion> listarPresentacionProducto(int idMarca,int idCategoria)
        {
            List<Presentacion> lista = new List<Presentacion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT distinct P.ID,P.DESCRIPCION from Presentacion P INNER JOIN Productos Prod on Prod.IDCategoria=P.ID where Prod.IDMarca = "+idMarca+" and Prod.IDCategoria = "+idCategoria+"");
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

