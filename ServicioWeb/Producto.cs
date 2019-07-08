using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWeb
{
    public class Producto
    {
        public Producto(int idProducto, string description, string detalle, int stock, decimal precio, string imagen)
        {
            this.idProducto = idProducto;
            this.description = description;
            this.detalle = detalle;
            this.stock = stock;
            this.precio = precio;
            this.imagen = imagen;
        }

        public Producto()
        {
            this.idProducto = 0;
            this.description = "";
            this.detalle = "";
            this.stock = 0;
            this.precio = 0;
            this.imagen = "";

        }

        public int idProducto { get; set; }
        public string description { get; set; }
        public string detalle { get; set; }
        public int stock { get; set; }

        public decimal precio { get; set; }
        public string imagen { get; set; }
        

      }
    }
}