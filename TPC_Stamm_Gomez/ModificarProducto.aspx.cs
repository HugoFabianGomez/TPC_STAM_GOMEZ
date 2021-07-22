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
    public partial class ModificarProducto : System.Web.UI.Page
    {
        
                public Producto nuevo = new Producto();
                public ProductoNegocio conexion = new ProductoNegocio();
                public MarcasNegocio negocio = new MarcasNegocio();
                public CategoriaNegocio catNegocio = new CategoriaNegocio();
                public PresentacionNegocio presentacionNegocio = new PresentacionNegocio();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["idP"] != null)
                {

                    int id = int.Parse(Request.QueryString["idP"].ToString());
                    Session["idProductoModificar"] = id;
                    nuevo = conexion.cargarProducto(id);
                    Session["descripcionProductoModificar"] = nuevo.descripcion;

                    Session["precioProductoModificar"] = nuevo.precioUnitario;

                    txtMarca.Text = nuevo.marcas.getNombreMarca();
                    Session["idMarcaModificar"] = nuevo.marcas.getId();

                    txtDescripcion.Text = nuevo.descripcion;
                    Session["descripcionModificar"] = nuevo.descripcion;

                    txtPresentacion.Text = nuevo.presentacion.getDescripcion();
                    Session["idPresentacionModificar"] = nuevo.presentacion.getId();

                    txtCategoria.Text = nuevo.categorias.getNombreCategoria();
                    Session["idCategoriaModificar"] = nuevo.categorias.getId();

                    txtPrecio.Text = nuevo.precioUnitario.ToString();
                    Session["precioModificar"] = nuevo.precioUnitario.ToString();
                }

                ddlMarcas.DataSource = negocio.listar();
                ddlMarcas.DataValueField = "idMarcas";
                ddlMarcas.DataTextField = "nombreMarcas";
                ddlMarcas.DataBind();
                ddlMarcas.Items.Insert(0, new ListItem("Seleccione una Marca"));

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
        protected void Modificar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion1.Text != "")
            {
                nuevo.descripcion = txtDescripcion1.Text;
            }
            if (txtPrecio1.Text!="")
            {
                nuevo.precioUnitario = decimal.Parse(txtPrecio1.Text);
            }
            nuevo.categorias=new Categorias(int.Parse(Session["idCategoriaModificar"].ToString()));
            nuevo.marcas=new Dominio.Marcas(int.Parse(Session["idMarcaModificar"].ToString()));
            nuevo.presentacion=new Presentacion (int.Parse(Session["idPresentacionModificar"].ToString()));
            nuevo.id = int.Parse(Session["idProductoModificar"].ToString());
            nuevo.precioUnitario = decimal.Parse(Session["precioProductoModificar"].ToString());
            nuevo.descripcion = Session["descripcionProductoModificar"].ToString();

            conexion.modificar(nuevo);

        }

        protected void ddlMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMarcas = int.Parse(ddlMarcas.SelectedItem.Value.ToString());
            if (idMarcas!=0)
            {
                Session["idMarcaModificar"] = idMarcas;
            }

        }

        protected void ddlPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int idPresentacion;
                idPresentacion = int.Parse(ddlPresentacion.SelectedItem.Value);
                string valor = ddlPresentacion.SelectedItem.Value;
                if (idPresentacion != 0)
                {
                    Session["idpresentacionmodificar"] = idPresentacion;
                }
            }
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(ddlCategoria.SelectedItem.Value);
            if (idCategoria != 0)
            { 
                Session["idCategoriaModificar"] = idCategoria;
            }
        }
    }
}