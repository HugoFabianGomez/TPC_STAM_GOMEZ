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
    public partial class EliminarStock : System.Web.UI.Page
    {
        public Stock nuevo = new Stock();
        StockNegocio conexion = new StockNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idS"] != null)
            {

                int IdStock = int.Parse(Request.QueryString["idS"].ToString());
                Session["idStock"] = IdStock;
                nuevo = conexion.traigoidStock(IdStock);
                text_idStock.Text = nuevo.idStock.ToString();
                txt_descripcion.Text = nuevo.descripcion;
                text_fechaIngreso.Text = nuevo.fecha_Ingreso.ToString();
                text_cantidadingresada.Text = nuevo.cantidadIngresada.ToString();
                text_estadostock.Text = nuevo.estadoStock.ToString();
            }
        }

        protected void EliminarStock_Click(object sender, EventArgs e)
        {
            int idstock = int.Parse(text_idStock.Text);

            conexion.eliminar(idstock);
            Response.Redirect("EliminarStock.aspx");

        }
    }
}