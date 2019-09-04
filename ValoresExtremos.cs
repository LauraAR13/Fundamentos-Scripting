using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresExtremos_Ejercicio_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {

            double total = 0;
            Console.WriteLine("Por favor ingrese el nùmero de datos a evaluar (n)");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombreMayor = "";
            string nombreMenor = "";
            string nombre = "";

            while (i < n)
            {
                Console.WriteLine("Por favor ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese el nombre del usuario: ");
                nombre = Console.ReadLine();
                if (i == 0)
                {
                    max = edad;
                    min = edad;
                    nombreMayor = nombre;
                    nombreMenor = nombre;

                }
                if (edad > max)
                {
                    max = edad;
                    nombreMayor = nombre;

                }
                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;
                }
                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("El promedio de edad es de: " + promedio);
            Console.WriteLine("La edad màxima es de: " + max);
            Console.WriteLine("El nombre del mayor es de: " + nombreMayor);
            Console.WriteLine("La edad mìnima es de: " + min);
            Console.WriteLine("El nombre del menor es de: " + nombreMenor);
        }
    }
}
