using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_binarios_a_decimales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese 1 o 0 para el valor de  b5: ");
            int b5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 o 0 para el valor de  b4: ");
            int b4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 o 0 para el valor de  b3: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 o 0 para el valor de  b2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 o 0 para el valor de  b1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 o 0 para el valor de  b0: ");
            int b0 = int.Parse(Console.ReadLine());

            //Operaciones 
            double valordecimal = Math.Pow(b5 * 2, 5) + Math.Pow(b4 * 2, 4) + Math.Pow(b3 * 2, 3) + Math.Pow(b2 * 2, 2) + Math.Pow(b1 * 2, 1) + Math.Pow(b0 * 2, 0);
            Console.WriteLine("El valor equivalente en decimal es: " + valordecimal);
        }
    }
}
