﻿using System;
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
        private AccesoDatos datos2;
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
                                    "GROUP by  P.ID, M.NOMBRE, PR.DESCRIPCION, C.NOMBRECATEGORIA,P.DESCRIPCION ");
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

        public void agregar(Stock agregoStock)
        {
            AccesoDatos accesoStock = new AccesoDatos();
            try
            {
                //string insertar = "values( '" + agregoStock.id + "' , '" + agregoStock.fecha_Ingreso + "' , '" + agregoStock.cantidadIngresada + "' , '" + agregoStock.stock + "')";
                string insertar = "values( '" + agregoStock.id + "' , getdate() , '" + agregoStock.cantidadIngresada + "' , '" + agregoStock.stock + "')";
                accesoStock.setearConsulta("insert into StockProductos(idproducto, FECHA_Ingreso, CANTIDAAD, Stock)" + insertar);

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
                accesoModificar.setearConsulta("update stockproductos set idproducto = @idproducto, fecha_ingreso = @fecha_ingreso, cantidad = @cantidad, stock = @stock where id= @id");
                accesoModificar.setearParametro("@nombre", modificoStock.id);
                accesoModificar.setearParametro("@fecha_ingreso", modificoStock.fecha_Ingreso);
                accesoModificar.setearParametro("@cantidad", modificoStock.cantidadIngresada);
                accesoModificar.setearParametro("@stock", modificoStock.stock);
                accesoModificar.setearParametro("@id", modificoStock.id);//falta parametrizar el id de stockproducto

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
                datos.setearConsulta("Delete from stockproductos where id " + id);
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



        public List<Stock> listaTotal_Stock() //LISTA TOTAL DE LOS STOCKS QUE SE AGREGARONE  era "listaStock"
        {

            List<Stock> listado2 = new List<Stock>();  //era listado
            AccesoDatos datos2 = new AccesoDatos();    //era datos

            try
            {
                datos2.setearConsulta(" select ID, IDPRODUCTO, FECHA_INGRESO, CANTIDAD, STOCK from stockproductos");
                datos2.ejecutarLectura();
                while (datos2.Lector.Read())
                {
                    Stock aux2 = new Stock();
                    aux2.idStock = (int)datos2.Lector["ID"];
                    aux2.idproducto = ((Producto)datos2.Lector["IDPRODUCTO"]);
                    aux2.fecha_Ingreso = (DateTime)datos2.Lector["FECHA_INGRESO"];
                    aux2.cantidadIngresada = (int)datos2.Lector["CANTIDAD"];
                    aux2.stock = (int)datos2.Lector["Stock"];

                    listado2.Add(aux2);

                }

                return listado2;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos2.cerrarConexion();
            }
        }
    }
}
