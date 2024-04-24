using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marcas
    {
        public Marcas() 
        {
            IdMarcas = 0;
            Descripcion = "";
        }
        public Marcas(int IdMarcas = 0,string descripcion = "")
        {
            this.IdMarcas = IdMarcas;
            this.Descripcion = descripcion; 
        }
        public int IdMarcas { get; set; }
        public string Descripcion { get; set; }

        
        public override string ToString()
        {
            return Descripcion;
        }
        
    
    }
}
