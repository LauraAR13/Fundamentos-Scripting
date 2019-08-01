using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_y_elecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Total de votos por el partido 1: ");
            int votosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Total de votos por el partido 2: ");
            int votosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Total de votos en blanco: ");                     
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Total de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Total de poblacion de todas las edades: ");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de la poblacion mayor de edad : ");
            double mayorEdad = double.Parse(Console.ReadLine());

            int totalVotos = votosA + votosB + blanco + anulados; 
            double poblacionVotantes = (poblacion * mayorEdad) / 100;
            double abstencion = mayorEdad - totalVotos;

            bool a = anulados < 0.3*(votosA+votosB);
            bool b = (votosA + votosB) > (blanco);
            bool c = abstencion < totalVotos;

          if ((a || b) && (c))
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                if (votosA > votosB)
                {
                    Console.WriteLine("El ganador es el partido A");
                }

                else if (votosB>votosA)
                {
                    Console.WriteLine("El ganador es el partido B");
                }
                else 
                {
                    Console.WriteLine("Segunda vuelta");
                }

                
            }
          else
            {
                Console.WriteLine("Segunda vuelta");
            }


            
           
           
        }
    }
}
