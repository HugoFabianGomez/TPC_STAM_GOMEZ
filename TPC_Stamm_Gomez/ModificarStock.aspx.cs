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
            if (!IsPostBack)

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
                    text_idproducto.Text = nuevo.id.ToString();
                }
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
            Stock nuevo1 = new Stock();

            nuevo1.idStock = int.Parse(text_idstock.Text);
            nuevo1.descripcion = text_descripcion.Text;
            nuevo1.fecha_Ingreso = (DateTime.Parse(text_fechaingreso.Text));
            nuevo1.cantidadIngresada = int.Parse(text_cantidad.Text);
            nuevo1.stock = int.Parse(text_stock.Text);
            nuevo1.estadoStock = bool.Parse(text_estadostock.Text);
            nuevo1.id = int.Parse(text_idproducto.Text);

            conexion.modificar(nuevo1);

        }

        protected void txtidstock_TextChanged1(object sender, EventArgs e)
        {
        }

        protected void text_cantidad_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(text_cantidad.Text);
        }
    }
}