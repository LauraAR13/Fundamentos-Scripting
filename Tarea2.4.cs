using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos 
            Console.WriteLine("Ingrese el valor de la hipotenusa w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la hipotenusa t: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del angulo c: ");
            double cGrados = double.Parse(Console.ReadLine());

            //Convertir el angulo c a radianes
            double c = cGrados * (Math.PI / 180.0);

            //Hallar el angulo a y convertirlo a radianes
            double aGrados = 90.0 - cGrados;
            double a = aGrados * (Math.PI / 180.0);

            //Hallar el angulo e 
            double eGrados = 180.0 - cGrados;

            //Hallar el valor del cateto z
            double z = (Math.Cos(a) * t);

            //Hallar el valor de y
            double y = (Math.Sin(a) * t);

            //Hallar el valor de ab en radianes y convertirlo a grados 
            double ab = (Math.Acos(z / w));
            double abGrados = ab * (180.0 / Math.PI);

            //Hallar el valor de x 
            Console.Write("El valor del lado x es :");
            double x = (Math.Sin(ab) * w) - y;
            Console.WriteLine(x);
            Console.ReadLine();






        }

    }
}
