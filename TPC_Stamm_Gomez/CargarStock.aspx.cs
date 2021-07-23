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
                //nuevoStock.fecha_Ingreso = DateTime.Parse(text_fechaingreso.Text);
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

        }
    }
}