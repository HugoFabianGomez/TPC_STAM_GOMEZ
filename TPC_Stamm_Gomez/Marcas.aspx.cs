﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Stamm_Gomez
{
    public partial class Marcas : Page
    {
        public List<Marcas> marcas;
        protected void Page_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocios = new MarcasNegocio();

            try
            {
                //marcas = marcasNegocios.listaMarcas   .listaMarcas(); //marcasNegocio es la conexion listaMarcas es la funcion 

            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());

                Response.Redirect("Error.aspx");
            }
            




        }
    }
}