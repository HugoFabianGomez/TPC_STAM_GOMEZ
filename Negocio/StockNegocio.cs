using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{

    public class StockNegocio
    {
        private AccesoDatos datos;

        public List<Stock> listaStock() //SUMA EL RESUMEN DE STOCK QUE EXISTE
        {

            List<Stock> listado = new List<Stock>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(" SELECT P.ID CodProducto,P.DESCRIPCION Descripcion, M.NOMBRE Producto,PR.DESCRIPCION Presentacion,ISNULL(SUM(S.Stock),0) Stock," +
                                    "C.NOMBRECATEGORIA Sector from Productos P " +
                                   "INNER join StockProductos S on S.IDProducto = P.ID " +
                                    "inner join Marca M ON M.ID = P.IDMarca " +
                                    "INNER JOIN Presentacion PR ON PR.ID = P.IDPresentacion " +
                                    "inner join Categoria C on C.ID = P.IDCategoria " +
                                    "Where S.Estado = 1 GROUP by  P.ID, M.NOMBRE, PR.DESCRIPCION, C.NOMBRECATEGORIA,P.DESCRIPCION ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Stock aux = new Stock();
                    aux.id = (int)datos.Lector["CodProducto"];
                    aux.marcas = new Marcas((string)datos.Lector["Producto"]);
                    aux.marcas.nombreMarcas = (string)datos.Lector["Producto"];
                    aux.stock = (int)datos.Lector["Stock"];
                    aux.categorias = new Categorias((string)datos.Lector["Sector"]);
                    aux.categorias.nombreCategoria = (string)datos.Lector["Sector"];
                    aux.presentacion = new Presentacion((string)datos.Lector["Presentacion"]);
                    aux.presentacion.descripcion = (string)datos.Lector["Presentacion"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

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

        public void eliminar(Stock id)
        {

            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update stockproductos set estado = 0 where id =" + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }

        }

        public void agregar(Stock agregoStock)
        {
            AccesoDatos accesoStock = new AccesoDatos();
            try
            {
                //string insertar = "values( '" + agregoStock.id + "' , '" + agregoStock.fecha_Ingreso + "' , '" + agregoStock.cantidadIngresada + "' , '" + agregoStock.stock + "')";
                string insertar = "values( '" + agregoStock.id + "' , getdate() , '" + agregoStock.cantidadIngresada + "' , '" + agregoStock.stock + "')";
                accesoStock.setearConsulta("insert into StockProductos(idproducto, FECHA_Ingreso, CANTIDAD, Stock)" + insertar);

                accesoStock.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoStock.cerrarConexion();

            }
        }

        public void modificar(Stock modificoStock)
        {
            AccesoDatos accesoModificar = new AccesoDatos();
            try
            {
                accesoModificar.setearConsulta("update stockproductos set idproducto = @idproducto, fecha_ingreso = @fecha_ingreso, cantidad = @cantidad, stock = @stock where id= @idStock");

                accesoModificar.setearParametro("@idStock", modificoStock.idStock);
                accesoModificar.setearParametro("@idproducto", modificoStock.id);
                accesoModificar.setearParametro("@fecha_ingreso", modificoStock.fecha_Ingreso);
                accesoModificar.setearParametro("@cantidad", modificoStock.cantidadIngresada);
                accesoModificar.setearParametro("@stock", modificoStock.stock);
                accesoModificar.setearParametro("@estado", modificoStock.estadoStock);//falta parametrizar el id de stockproducto

                accesoModificar.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoModificar.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update stockproductos set estado = '0' where id =" + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }

        public Stock traigoidStock(int IdStock)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@id", IdStock);
                datos.setearConsulta("select s.ID, p.DESCRIPCION, s.FECHA_Ingreso, s.CANTIDAD, s.stock, s.Estado, s.idproducto from stockProductos s inner join Productos p on s.IDProducto=p.ID where s.id = " + IdStock);
                datos.ejecutarLectura();
                datos.Lector.Read();

                Stock aux = new Stock();
                aux.idStock = (int)datos.Lector["ID"];
                aux.descripcion = (string)datos.Lector["DESCRIPCION"];
                aux.fecha_Ingreso = (DateTime)datos.Lector["FECHA_Ingreso"];
                //aux.categorias = new Categorias((string)datos.Lector["NOMBRECATEGORIA"]);
                aux.cantidadIngresada = (int)datos.Lector["CANTIDAD"];
                aux.stock = (int)datos.Lector["stock"];
                aux.estadoStock = (bool)datos.Lector["Estado"];
                aux.id = (int)datos.Lector["idproducto"];
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

        public List<Stock> Listamodificarstock(int id)
        {
            List<Stock> listamodificar = new List<Stock>();
            AccesoDatos dato1 = new AccesoDatos();
            try
            {
                dato1.setearConsulta("select s.ID, p.DESCRIPCION, s.FECHA_INGRESO, s.CANTIDAD, s.STOCK, s.ESTADO, p.ID as idproducto " +
                                        "from stockproductos s inner join Productos p on s.IDProducto = p.ID where s.id =" + id);
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
                    aux3.id = (int)dato1.Lector[""];

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
