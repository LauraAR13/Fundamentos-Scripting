using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.WriteLine("Ingrese el valor del lado w : ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del angulo d : ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado x : ");
            double x = double.Parse(Console.ReadLine());


            //Converttir el angulo d a radianes
            double d = dGrados * (Math.PI / 180.0);

            //Calcular el valor de z
            double z = (Math.Sin(d) * w);

            //Calcular el valor de y
            Console.WriteLine("El valor del lado y es de : ");
            double y = ((z / Math.Tan(d)) - x);
            Console.WriteLine(y);
            Console.ReadLine();
           

        }
    }
}
