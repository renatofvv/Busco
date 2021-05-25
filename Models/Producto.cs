using System;

namespace Busco.Models
{
    public class Producto
    {
        public int Id {get;set;}
    
        public string Nombre { get; set; }
        public string Foto {get; set;}

        public string Descripcion {get; set;}
        public double Precio {get; set; }
      
         public string Celular { get; set; }

         public string Lugar { get; set; }

         public string Usuario { get; set; }

         public string Categoria { get; set; }


    }
}