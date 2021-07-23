using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcasNegocio
    {
        public List<Marcas> listar()
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID ,NOMBRE from  Marca where Estado=1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.idMarcas = (int)datos.Lector["ID"];
                    aux.nombreMarcas = (string)datos.Lector["NOMBRE"];
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


        public List<Marcas> listaMarcaProductos()
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT M.ID ,M.NOMBRE from  Marca M INNER join Productos P on M.ID = P.IDMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.idMarcas = (int)datos.Lector["ID"];
                    aux.nombreMarcas = (string)datos.Lector["NOMBRE"];
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



        public Marcas cargarMarca(int idMarc)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@idM", idMarc);
                datos.setearConsulta("SELECT ID,NOMBRE from Marca where ID=@idM");
                datos.ejecutarLectura();
                datos.Lector.Read();

                Marcas aux = new Marcas();
                aux.idMarcas = (int)datos.Lector["ID"];
                aux.nombreMarcas = (string)datos.Lector["NOMBRE"];
                return aux;
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

        public void eliminarMarca(int idMarca)//Baja loogica
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Marca set ESTADO = 0  WHERE ID=" + idMarca + "");
                datos.ejectutarAccion();
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

