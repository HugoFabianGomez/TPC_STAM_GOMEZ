using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
namespace Negocio
{
    public class ModificarStockNegocio
    {
        public List<Stock> Listamodificarstock(int id)
        {
            List<Stock> listamodificar = new List<Stock>();
            AccesoDatos dato1 = new AccesoDatos();
            try
            {
                dato1.setearConsulta("select s.ID, s.FECHA_INGRESO, s.CANTIDAD, s.STOCK from stockproductos s inner join Productos p on s.IDProducto=p.ID where s.id ="+ id);
                dato1.ejecutarLectura();

                while (dato1.Lector.Read())
                {
                    Stock aux3 = new Stock();
                    aux3.idStock = (int)dato1.Lector["ID"];
                    aux3.descripcion = (string)dato1.Lector["DESCRIPCION"];
                    aux3.fecha_Ingreso = (DateTime)dato1.Lector["FECHA_INGRESO"];
                    aux3.cantidadIngresada = (int)dato1.Lector["CANTIDAD"];
                    aux3.stock = (int)dato1.Lector["STOCK"];
                    aux3.estadoStock = (bool)dato1.Lector["ESTADO"];

                    listamodificar.Add(aux3);
                    
                }
                return listamodificar;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato1.cerrarConexion();
            }

            
        }


       


    }
}
