using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Por favor ingrese el valor de su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            if (  salario < 1656232)
            {
                Console.WriteLine("Usted pertenece a la tarifa A");
            }

            else if (1656232<= salario && salario < 3312464)
            {
                Console.WriteLine("Usted pertenece a a la tarifa B");
            }

            else
            {
                Console.WriteLine("Usted pertenece a la tarifa C");

            }
            Console.ReadLine();

        }
    }
}
