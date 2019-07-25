using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_de_tarea_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.WriteLine("Ingrese el valor del angulo b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto y: " );
            double y = double.Parse(Console.ReadLine());

            //Conversion a radianes
            double b = bGrados * (Math.PI / 180.0);

            //Hallar la hipotenusa t
            double t = Math.Sqrt((z * z) + (y * y));

            //Hallar el angulo c 
            double c = Math.Asin(z / t);

            //Hallar el angulo e 
            double e = (c - 180);

            //Hallar el angulo a 
            double a = b + e - 180;

            //Hallar el angulo d
            double d = e + bGrados - 180;

            //Hallar x con la ley de senos
            Console.Write("El valor del lado x es :");
            double x = (t * (Math.Sin(b))) / Math.Sin(d);
            Console.WriteLine(x);
            Console.ReadLine();







        }
    }
}
