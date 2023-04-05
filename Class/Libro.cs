using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._3_Cs.Class
{
    internal class Libro : Producto
    {
        public Libro(string titulo, double precio, double costo) : base(titulo, precio, costo)
        {
            // Código adicional si lo hay
        }

        public override string ImprimirDatos()
        {
            return "Book: " + nombreProducto + " Price: " + precioVenta;
        }

    }
}
