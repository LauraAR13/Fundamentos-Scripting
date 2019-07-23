using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir los catetos
            Console.Write("Inserte el valor de Y:");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Inserte el valor de Z:");
            double Z = double.Parse(Console.ReadLine());


            //Hallar el valor de la hipotenusa 

            Console.Write("El valor de la hipotenusa es:");
            double t = Math.Sqrt((Y * Y) + (Z * Z));
            Console.WriteLine(t);

            //Hallar el valor del angulo a 

            double a = Math.Atan(Y / Z);
            double A = a * (180 / Math.PI);
            Console.Write("El valor del angulo A:");
            Console.WriteLine(A);

            //Hallar el valor del angulo c 

            double c = Math.Atan(Z / Y);
            double C = c * (180 / Math.PI);
            Console.Write("El valor del angulo C:");
            Console.WriteLine(C);
            Console.ReadLine();
        }
    }
}
