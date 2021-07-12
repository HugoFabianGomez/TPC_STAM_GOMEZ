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
    public partial class HistorialStock : System.Web.UI.Page
    {
        public List<Stock> historia;
        protected void Page_Load(object sender, EventArgs e)
        {
            HistorialNegocio conexionBase = new HistorialNegocio();

            try
            {
                historia = conexionBase.List_Historial();//va a la base y me trae todo el stock

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());

                Response.Redirect("Error.aspx");
            }

        }
    }
}