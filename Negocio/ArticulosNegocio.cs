using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dominio;
using Negocio;

namespace TP2_WinForm.Negocio
{
    public class ArticulosNegocio
    {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
        public ArticulosNegocio()
        {
            conexion= new SqlConnection("server= .\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando= new SqlCommand("");

        }
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                conexion.ConnectionString = "server= .\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, m.Descripcion AS Marca, c.Descripcion AS Categoria, a.Precio, i.ImagenUrl FROM ARTICULOS a\r\nJOIN MARCAS m ON m.Id = a.IdMarca\r\nJOIN IMAGENES i ON i.Id = m.Id\r\nLEFT JOIN CATEGORIAS c ON c.Id = a.IdCategoria\r\nORDER BY a.Nombre ASC;";                                  
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    
                    //Lector obtiene los nombres de las columnas de la BD
                    aux.CodArticulo = (string)lector["codigo"];
                    aux.Nombre = (string)lector["nombre"];
                    aux.Descripcion = (string)lector["descripcion"];
                    aux.Precio = decimal.Parse(lector["precio"].ToString());
                    aux.Marcas = new Marcas();
                    aux.Marcas.Descripcion = (string)lector["Marca"];

                    aux.Categorias = new Categorias(); 
                    if (!(lector["Categoria"] is DBNull)) // Validacion datos NULOS.
                        aux.Categorias.Descripcion = (string)lector["Categoria"]; // Si es NULL queda vacio, sino asigna el valor a la propiedad.
                    
                    lista.Add(aux);
                    
                }
                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarArticulo(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");     
                datos.SeterParametros("@Codigo", nuevo.CodArticulo);
                datos.SeterParametros("@Nombre", nuevo.Nombre);
                datos.SeterParametros("@Descripcion", nuevo.Descripcion);
                datos.SeterParametros("@IdMarca", nuevo.Marcas.IdMarcas);
                datos.SeterParametros("@IdCategoria", nuevo.Categorias.IdCategoria);
                datos.SeterParametros("@Precio", nuevo.Precio);

                conexion.Close();
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void ModificarArticulo()
        {

        }
        public bool verificadorDeCodigos(string codigo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE Codigo = @CodArticulo");
                comando.Parameters.AddWithValue("Codigo", codigo);
                datos.EjecutarConsulta();

                if (datos.Lector.Read())
                {
                    int count = datos.Lector.GetInt32(0);
                    return count > 0;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
        

        }
        public void AgregarImagen(Articulos nuevoArticulo)
        {
            Articulos articulo = new Articulos();
            AccesoDatos datos = new AccesoDatos();
            articulo = listar().Last();

            try
            {

                int idArticulo = articulo.IdArticulo;
                datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.SeterParametros("@IdArticulo", idArticulo);
                datos.SeterParametros("@ImagenUrl", nuevoArticulo.Imagen);

                conexion.Close();
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}