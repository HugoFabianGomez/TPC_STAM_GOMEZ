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
            txtidstock.Text = (string)"55";
        }

        protected void txtidstock_TextChanged(object sender, EventArgs e)
        {
            ModificarStockNegocio modificarStock = new ModificarStockNegocio(); //conexion


            try
            {
                int id = int.Parse(txtidstock.Text);
                UnRegistro = modificarStock.Listamodificarstock(id);
                //PROBLEMA NO TRAE AL "Listamodificarstock" DICE NO EXISTE EN EL CONTEXTO;

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());

                Response.Redirect("Error.aspx");
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        protected void txtidstock_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}