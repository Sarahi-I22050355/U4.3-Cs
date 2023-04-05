using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._3_Cs.Class
{
    internal class DVD : Producto
    {
        public DVD(string titulo, double precio, double costo) : base(titulo, precio, costo)
        {
            // Código adicional si lo hay
        }

        public override string ImprimirDatos()
        {
            return "DVD: " + nombreProducto + " Price: " + precioVenta;
        }

    }
}
