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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            { 
                MarcasNegocio negocio = new MarcasNegocio();



                if (!IsPostBack)
                {
                    
                    ddlMarcas.DataSource = negocio.listar();
                    ddlMarcas.DataValueField = "idMarcas";
                    ddlMarcas.DataTextField = "nombreMarcas";
                    ddlMarcas.DataBind();
                }


            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }

        }
    }
}