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
                comando.CommandText = "SELECT P.ID,P.DESCRIPCION,P.PRECIO_UNITARIO,C.NOMBRECATEGORIA,M.NOMBRE from Productos P INNER join Marca M ON M.ID = P.IDMarca INNER JOIN Categoria C ON C.ID = P.IDCategoria where P.ESTADO=1  GROUP BY P.ID,P.DESCRIPCION,P.PRECIO_UNITARIO,C.NOMBRECATEGORIA,M.NOMBRE";
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
                datos.setearParametro("@precio", nuevo.precioUnitario);
                datos.setearParametro("@estado", 1);
                datos.setearConsulta("INSERT INTO Productos(IDMarca,IDCategoria,IDPresentacion,DESCRIPCION,PRECIO_UNITARIO,ESTADO) " +
                    "values(@idMarcas,@idCategoria,@idPresentacion,@descripcion,@precio,@estado)");

                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarProducto(int idProducto)//Baja loogica
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Productos set ESTADO = 0  WHERE ID="+idProducto+"");
                datos.ejectutarAccion();              
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Producto cargarProducto(int idProd)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@id", idProd);
                datos.setearConsulta("SELECT P.ID,C.ID idCategoria,M.ID idMarca,Pre.ID idPresentacion, P.DESCRIPCION, P.PRECIO_UNITARIO, C.NOMBRECATEGORIA, M.NOMBRE ,PRE.DESCRIPCION AS Presentacion from Productos P INNER join Marca M ON M.ID = P.IDMarca INNER JOIN Categoria C ON C.ID = P.IDCategoria INNER JOIN Presentacion Pre ON PRE.ID=P.IDPresentacion  where P.ID = @id  GROUP BY P.ID, P.DESCRIPCION, P.PRECIO_UNITARIO, C.NOMBRECATEGORIA, M.NOMBRE,PRE.DESCRIPCION,C.ID,M.ID,Pre.ID");
                datos.ejecutarLectura();
                datos.Lector.Read();

                Producto aux = new Producto();
                aux.id = (int)datos.Lector["ID"];
                aux.descripcion = (string)datos.Lector["DESCRIPCION"];
                aux.precioUnitario = (decimal)datos.Lector["PRECIO_UNITARIO"];
                aux.categorias = new Categorias((string)datos.Lector["NOMBRECATEGORIA"]);
                aux.categorias.nombreCategoria = (string)datos.Lector["NOMBRECATEGORIA"];
                aux.marcas = new Marcas((string)datos.Lector["NOMBRE"]);
                aux.marcas.nombreMarcas = (string)datos.Lector["NOMBRE"];
                aux.presentacion = new Presentacion((string)datos.Lector["Presentacion"]);
                aux.presentacion.descripcion = (string)datos.Lector["Presentacion"];
                aux.categorias.id = (int)datos.Lector["idCategoria"];
                aux.marcas.idMarcas = (int)datos.Lector["idMarca"];
                aux.presentacion.id = (int)datos.Lector["idPresentacion"];
                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void modificar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@id",nuevo.id);
                datos.setearParametro("@idMarcas", nuevo.marcas.idMarcas);
                datos.setearParametro("@idCategoria", nuevo.categorias.id);
                datos.setearParametro("@idPresentacion", nuevo.presentacion.id);
                datos.setearParametro("@descripcion", nuevo.descripcion);
                datos.setearParametro("@precio", nuevo.precioUnitario);
                datos.setearParametro("@estado", 1);
                datos.setearConsulta("UPDATE Productos set  IDMarca=@idMarcas ,IDCategoria=@idCategoria ,IDPresentacion=@idPresentacion ,DESCRIPCION=@descripcion,PRECIO_UNITARIO=@precio,ESTADO=@estado where ID=@id");

                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
