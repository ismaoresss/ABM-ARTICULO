using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dominio;

namespace TP2_WinForm.Negocio
{
    internal class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

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
                    aux.Precio = float.Parse(lector["precio"].ToString());
                    aux.Imagen = new Imagenes();
                    aux.Imagen.ImagenUrl = (string)lector["imagenUrl"];
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
    }
}