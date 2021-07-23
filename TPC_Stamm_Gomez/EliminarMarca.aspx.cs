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
    public partial class EliminarMarca : System.Web.UI.Page
    {
        
        public Marcas nuevo = new Marcas();
        public MarcasNegocio negocio = new MarcasNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["idM"] != null)
                    {
                         int idM = int.Parse(Request.QueryString["idM"].ToString());
                        Session["idMarcaEliminar"] = idM;
                        Dominio.Marcas nuevo =  negocio.cargarMarca(idM);
                        txtID.Text =  nuevo.idMarcas.ToString();
                        txtMarca.Text = nuevo.nombreMarcas;

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int idMar = int.Parse(Session["idMarcaEliminar"].ToString());
            negocio.eliminarMarca(idMar);
            Response.Redirect("EliminarMarca.aspx");

        }
    }
}