using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;
using TP2_WinForm.Clases;

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
                comando.CommandText = "select a.nombre, a.descripcion, a.precio, i.imagenurl from articulos a\r\njoin imagenes i on a.id=i.id;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    Imagenes auxImagenes = new Imagenes();
                    aux.Nombre = (string)lector["nombre"];
                    aux.Descripcion = (string)lector["descripcion"];
                    aux.Precio = float.Parse(lector["precio"].ToString());
                    aux.Imagen = new Imagenes();
                    aux.Imagen.ImagenUrl = (string)lector["imagenUrl"];

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