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
    public partial class ListadoProductos : System.Web.UI.Page
    {
        public List<Producto> listas;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                listas = negocio.listaProducto();//hago la consulta a la base 

            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());

                Response.Redirect("Error.aspx");
            }

        }
    }
}