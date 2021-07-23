using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class HistorialNegocio
    {
        public List<Stock> List_Historial()
        {
            List<Stock> historial = new List<Stock>();
            AccesoDatos dato = new AccesoDatos();

            try
            {
                dato.setearConsulta("select S.ID ID, P.DESCRIPCION Descripcion, S.FECHA_Ingreso Fecha, S.CANTIDAD Cantidad," +
                                    "M.NOMBRE Marca, P.id idproducto from StockProductos S inner join Productos P on S.idproducto = P.ID " +
                                    "inner join Marca M on M.ID = P.IDMarca where S.Estado = 1");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Stock aux2 = new Stock();
                    aux2.idStock = (int)dato.Lector["ID"];
                    aux2.descripcion = (string)dato.Lector["Descripcion"];
                    aux2.fecha_Ingreso = (DateTime)dato.Lector["Fecha"];
                    aux2.cantidadIngresada = (int)dato.Lector["Cantidad"];
                    aux2.marcas = new Marcas((string)dato.Lector["Marca"]);
                    aux2.marcas.nombreMarcas = (string)dato.Lector["Marca"];
                    aux2.id = (int)dato.Lector["idproducto"];


                    historial.Add(aux2);
                }
                return historial;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }

        }
    }
}
