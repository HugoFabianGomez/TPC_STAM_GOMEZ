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
        

        public List<Marcas> listaMarcas() //SUMA EL RESUMEN DE STOCK QUE EXISTE
        {

            List<Marcas> listado = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(" SELECT id, nombre from marca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.idMarcas = (int)datos.Lector["ID"];
                    aux.nombreMarcas = (string)datos.Lector["NOMBRE"];

                    listado.Add(aux);

                }

                return listado;
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
