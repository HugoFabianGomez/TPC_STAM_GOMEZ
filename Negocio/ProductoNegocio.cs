using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listaProducto()
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=StokDepot_StammGomez; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT P.ID,P.DESCRIPCION,P.PRECIO_UNITARIO,C.NOMBRECATEGORIA,M.NOMBRE from Productos P INNER join Marca M ON M.ID = P.IDMarca INNER JOIN Categoria C ON C.ID = P.IDCategoria GROUP BY P.ID,P.DESCRIPCION,P.PRECIO_UNITARIO,C.NOMBRECATEGORIA,M.NOMBRE";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Producto aux = new Producto();
                    aux.id = (int)lector["ID"];
                    aux.descripcion = (string)lector["DESCRIPCION"];
                    aux.precioUnitario = (decimal)lector["PRECIO_UNITARIO"];
                    aux.categorias = new Categorias((string)lector["NOMBRECATEGORIA"]);
                    aux.categorias.nombreCategoria = (string)lector["NOMBRECATEGORIA"];
                    aux.marcas = new Marcas((string)lector["NOMBRE"]);
                    aux.marcas.nombreMarcas = (string)lector["NOMBRE"];
                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@idMarcas", nuevo.marcas.idMarcas);
                datos.setearParametro("@idCategoria", nuevo.categorias.id);
                datos.setearParametro("@idPresentacion", nuevo.presentacion.id);
                datos.setearParametro("@descripcion", nuevo.descripcion);
                datos.setearParametro("@peso", nuevo.peso);
                datos.setearParametro("@precio", nuevo.precioUnitario);
                datos.setearParametro("@estado", 1);
                datos.setearConsulta("INSERT INTO Productos(IDMarca,IDCategoria,IDPresentacion,DESCRIPCION,PRECIO_UNITARIO,PESO,ESTADO) " +
                    "values(@idMarcas,@idCategoria,@idPresentacion,@descripcion,@precio,@peso,@estado)");

                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
