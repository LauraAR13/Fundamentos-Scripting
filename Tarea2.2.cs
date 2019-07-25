using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_de_Tarea_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.WriteLine("Ingrese el valor del angulo d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del angulo b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto y: ");
            double y = double.Parse(Console.ReadLine());

            //Hallar el angulo e 
            double eGrados = 180.0-(dGrados+bGrados);

            //Hallar el angulo c y convertirlo a radianes
            double cGrados = 180.0-eGrados;
            double c = cGrados * (Math.PI / 180.0);

            //Hallar el cateto z
            Console.Write("El valor del cateto z es: ");
            double z= ((Math.Tan (c)) * y );
            Console.WriteLine(z);
            Console.ReadLine();


        }

    }
}
