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
        public List<Stock> UnRegistro;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtidstock_TextChanged(object sender, EventArgs e)
        {
            ModificarStock modificarStock = new ModificarStock(); //conexion

            try
            {
                UnRegistro = modificarStock.     PROBLEMA NO TRAE AL Listamodificarstock DICE NO EXISTE EN EL CONTEXTO;

            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());

                Response.Redirect("Error.aspx");
            }

        }
    }
}