using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U4._3_Cs.Class;

namespace U4._3_Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro("Programming Fundamentals", 54.95, 39.95);
            DVD miDVD = new DVD("Java Multimedia Course", 29.95, 19.95);

            Console.WriteLine("The data of my products.");
            Console.WriteLine(miLibro.ImprimirDatos());
            Console.WriteLine(miDVD.ImprimirDatos());

            Console.WriteLine("Press enter to close.");
            Console.ReadLine();
        }
    }
}
