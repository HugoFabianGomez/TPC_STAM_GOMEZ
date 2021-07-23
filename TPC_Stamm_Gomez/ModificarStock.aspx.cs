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
	public partial class ModificarStock : System.Web.UI.Page
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
                text_idstock.Text = nuevo.idStock.ToString();
                text_descripcion.Text = nuevo.descripcion;
                text_fechaingreso.Text = nuevo.fecha_Ingreso.ToShortDateString();
                text_cantidad.Text = nuevo.cantidadIngresada.ToString();
                text_stock.Text = nuevo.stock.ToString();
                text_estadostock.Text = nuevo.estadoStock.ToString();
            }
        }

        protected void txtidstock_TextChanged(object sender, EventArgs e)
        {



        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idStock = int.Parse(text_idstock.Text);

            //conexion.modificar(idStock);
        }

        protected void txtidstock_TextChanged1(object sender, EventArgs e)
        {





        }
    }
}