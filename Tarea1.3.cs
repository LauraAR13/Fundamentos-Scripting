using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.Write("Inserte el valor del angulo c (en caso de que sea un decimal utilice la coma): ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Inserte el valor del cateto z (en caso de que sea un decimal utilice la coma): ");
            double z = double.Parse(Console.ReadLine());

            //Conversion a Radianes de los datos ingresados
            double C = c * (Math.PI / 180.0);

            //Calculo del valor del angulo a
            Console.Write("El valor del angulo a es: ");
            double a = (90 - c);
            Console.WriteLine(a);

            //Calculo de la hipotenusa t
            Console.Write("El valor de la hipotenusa t es: ");
            double t = (z / Math.Sin(C));
            Console.WriteLine(t);

            //Calculo del cateto y
            Console.Write("El valor del cateto y es: ");
            double y = (Math.Cos(C) * t);
            Console.WriteLine(y);
            Console.ReadLine();




        }
    }
}
