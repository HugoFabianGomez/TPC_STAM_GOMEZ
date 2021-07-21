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
        public int idMarcas,idCategoria,idPresentacion;
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            { 
                MarcasNegocio negocio = new MarcasNegocio();
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                PresentacionNegocio presentacionNegocio = new PresentacionNegocio();



                if (!IsPostBack)
                {
                    
                    ddlMarcas.DataSource = negocio.listar();
                    ddlMarcas.DataValueField = "idMarcas";
                    ddlMarcas.DataTextField = "nombreMarcas";
                    ddlMarcas.DataBind();
                    ddlMarcas.Items.Insert(0,new ListItem ("Seleccione una Marca"));

                    ddlCategoria.DataSource = catNegocio.listar();
                    ddlCategoria.DataValueField = "id";
                    ddlCategoria.DataTextField = "nombreCategoria";
                    ddlCategoria.DataBind();
                    ddlCategoria.Items.Insert(0, new ListItem("Seleccione una Categoria"));

                    ddlPresentacion.DataSource = presentacionNegocio.listar();
                    ddlPresentacion.DataValueField = "id";
                    ddlPresentacion.DataTextField = "descripcion";
                    ddlPresentacion.DataBind();
                    ddlPresentacion.Items.Insert(0, new ListItem("Presentacion"));


                }



            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }

        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto();
            ProductoNegocio negocio = new ProductoNegocio();

            nuevo.marcas = new Dominio.Marcas();
            nuevo.marcas.setId(idMarcas);
            nuevo.categorias = new Categorias(idCategoria);
            nuevo.presentacion = new Presentacion(idPresentacion);
            nuevo.descripcion = txtDescripcion.Text;
            nuevo.peso = int.Parse(txtPeso.Text);
            nuevo.precioUnitario = decimal.Parse(txtPrecio.Text);

            negocio.agregar(nuevo);

        }

        protected void ddlMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            idMarcas = int.Parse(ddlMarcas.SelectedItem.Value);

        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCategoria = int.Parse(ddlCategoria.SelectedItem.Value);
        }

        protected void ddlPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPresentacion = int.Parse(ddlPresentacion.SelectedItem.Value);
        }
    }
}