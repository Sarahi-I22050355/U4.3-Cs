using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._3_Cs.Class
{
    internal abstract class Producto
    {
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreProducto;

        public Producto(string nombre, double precio, double costo)
        {
            nombreProducto = nombre;
            costoFabrica = costo;
            precioVenta = precio;
        }

        public abstract string ImprimirDatos();

    }
}
