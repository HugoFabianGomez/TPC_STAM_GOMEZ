using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Stamm_Gomez
{
    public partial class CargarStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Stock nuevoStock = new Stock();
            StockNegocio stockNegocio = new StockNegocio();
            try
            {
                nuevoStock.id = int.Parse(text_idproducto.Text);
                nuevoStock.fecha_Ingreso = DateTime.Parse(text_fechaingreso.Text);
                nuevoStock.cantidadIngresada = int.Parse(text_cantidad.Text);
                nuevoStock.stock = int.Parse(text_stock.Text);

                stockNegocio.agregar(nuevoStock); //conexion
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Response.Redirect("HistorialStock.aspx");
            }

        }

        protected void btn_Emiminar_Click(object sender, EventArgs e)
        {
            

        }//PREGUNTAR COMO ELIMINAR ESTE EVENTO

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            StockNegocio stockNegocio = new StockNegocio();
            try
            {       
                int id  = int.Parse(text_idStock.Text);

                stockNegocio.eliminar(id); //conexion return

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Response.Redirect("HistorialStock.aspx");
            }
        }

        protected void btn_Mostrar_Click(object sender, EventArgs e)
        {

            //List<Stock> traer = new List<Stock>();
            AccesoDatos dato1 = new AccesoDatos();

            try
            {

                dato1.setearConsulta("select ID, IDPRODUCTO from stockproductos where id = 46 and estado = 1");
                dato1.ejecutarLectura();

                while (dato1.Lector.Read())
                {
                    //Stock aux2 = new Stock();

                    text_idStock.Text       = (string)dato1.Lector["ID"];
                    text_idproducto.Text    = (string)dato1.Lector["IDPRODUCTO"];
                    //text_fechaingreso.Text  = (string)dato1.Lector["FECHA_INGRESO"];
                    //text_cantidad.Text      = (string)dato1.Lector["CANTIDAD"];
                    //text_stock.Text         = (string)dato1.Lector["STOCK"];

                    //aux2.idStock = (int)dato1.Lector["ID"];
                    //aux2.id = (int)dato1.Lector["IDPRODUCTO"];
                    //aux2.fecha_Ingreso = (DateTime)dato1.Lector["FECHA_INGRESO"];
                    //aux2.cantidadIngresada = (int)dato1.Lector["CANTIDAD"];
                    //aux2.stock = (int)dato1.Lector["STOCK"];    
                }

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