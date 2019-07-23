using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.Write("Inserte el valor de la hipotenusa t (si es un numero decimal utilice la coma): ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Inserte el valor del angulo a (si es un numero decimal utilice la coma) : ");
            double a = double.Parse(Console.ReadLine());

            //Convertir a en radianes
            double A = a * (Math.PI / 180.0);


            //Calculo del valor del angulo c
            Console.Write("El valor del angulo c es: ");
            double c = (90 - a);
            Console.WriteLine(c);

            //Calculo del valor del cateto y
            Console.Write("El valor del cateto y es: ");
            double y = (Math.Sin(A) * t);
            Console.WriteLine(y);

            //Calculo del valor del cateto z
            Console.Write("El valor del cateto z es: ");
            double z = (Math.Cos(A) * t);
            Console.WriteLine(z);
            Console.ReadLine();
        }

    }
}
