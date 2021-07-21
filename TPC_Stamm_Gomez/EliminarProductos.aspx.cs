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
    public partial class EliminarProductos : System.Web.UI.Page
    {
        public Producto nuevo = new Producto();
        ProductoNegocio conexion = new ProductoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idP"]!= null)
            {
                
                int id=int.Parse(Request.QueryString["idP"].ToString());
                Session["idProducto"] = id;
                nuevo = conexion.cargarProducto(id);
                txtMarca.Text = nuevo.marcas.getNombreMarca();
                txtDescripcion.Text = nuevo.descripcion;
                txtPresentacion.Text = nuevo.presentacion.getDescripcion();
                txtCategoria.Text = nuevo.categorias.getNombreCategoria();
            }
           

        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id =  int.Parse(Session["idProducto"].ToString());
            conexion.eliminarProducto(id);
        }
    }
}