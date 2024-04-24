using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
   public class Articulos
     
    {
        public Articulos()
        {
            IdArticulo = 0;
            CodArticulo = "";
            Nombre = "";
            Descripcion = "";
            Marcas = new Marcas();  
            Categorias = new Categorias();
            Imagen = new Imagenes();
            Precio = 0;

        }
        public Articulos(string codigoArt, string nombreArt, string descripcionArt, Marcas marcaArt, Categorias categoriaArt, string imagenes, float precio)
        {
            IdArticulo = 0;
            CodArticulo = "";
            Nombre = "";
            Descripcion = "";
            Marcas = new Marcas();
            Categorias = new Categorias();
            Imagen = new Imagenes();
            Precio = 0;
        }

        public int IdArticulo { get; set; }
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public Imagenes Imagen { get; set; }
        public Marcas Marcas { get; set; }
        public Categorias Categorias { get; set; }

    }
}
