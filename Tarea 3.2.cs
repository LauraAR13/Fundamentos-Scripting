using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.WriteLine("Ingrese el monto de su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 1656232)
            {
                Console.WriteLine("Usted pertenece a la tarifa A: ");
                Console.WriteLine("Su cuota moderadora para citas generales es de $3200");
            }

            else if  (1656232 <= salario && salario < 3312464)
            {
                Console.WriteLine("Usted pertenece a la tarifa B: ");
                Console.WriteLine("Su cuota moderadora para citas generales es de $12725");
            }

            else
            {
                Console.WriteLine("Usted pertenece a la tarifa C: ");
                Console.WriteLine("Su cuota moderadora para citas generales es de $33500");
            }
            Console.ReadLine();

        }
    }
}
