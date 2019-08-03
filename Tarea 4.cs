using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Votos por el partido 1: ");
            int votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos por el partido 2: ");
            int votos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos por en blanco: ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Poblacion de todas las edades: ");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de la poblacion que es mayor de edad: ");
            int mayorEdad = int.Parse(Console.ReadLine());

            //Total de votos y poblacion votante 
            int totalVotos = votos1 + votos2 + blanco + anulados;

            int diferencia = votos1 - votos2;


            bool a = totalVotos > poblacion;//Total de votos superior a total de poblacion 
            bool b = Math.Abs(diferencia) < (totalVotos * 0.1);
            bool c = (totalVotos < (poblacion * 0.3));

            if ((a || b) && c)
            {
                Console.WriteLine("Las votaciones deben repetirse");

            }
            else
            {
                if (votos1 > votos2)
                {
                    Console.WriteLine("El patido 1 es el ganador");
                }
                else if (votos2 > votos1)
                {
                    Console.WriteLine("El partido 2 es el ganador");
                }
                else Console.WriteLine("Las votaciones deben repetirse");
            }
            


        }
    }
}
