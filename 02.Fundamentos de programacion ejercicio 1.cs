using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fundamentos_de_programación
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Ingrese el valor de la coordenada x1: ");
            double  x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la coordenada y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la coordenada x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la coordenada y2: ");
            double y2 = double.Parse(Console.ReadLine());

            //Operaciones 
            double m = (y2 - y1) / (x2 - x1); // Cálculo de la pendiente 
            double b = ((y1) - (m)*(x1)); //Cálculo de el intercepto
            double distancia = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));

            //Salida de datos 
            Console.WriteLine("La pendiente es: " + m);
            Console.WriteLine("El intercepto es: " + b);
            Console.WriteLine("La distancia es: " + distancia);







        }

    }
}
