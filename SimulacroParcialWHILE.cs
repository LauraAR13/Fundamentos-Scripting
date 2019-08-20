using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcialWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("Bienvenido al juego");
            int dado1 = 0, total = 0, dado2 = 0, pares = 0, totales = 0;
            string continuar = "s";
            double mayor6 = 0;

            while (continuar == "s" && pares <3)
            {
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado1 = " + dado1);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado2 = " + dado2);
                totales += 1;
               if (dado1 == 1 && dado2 == 1 )
               {
                    Console.WriteLine("Usted ha perdido");
                    total = 0;
                    break;
               }
              else 
              {
                    total += dado1 + dado2;
                    Console.WriteLine("El total es de: " + total);
                    if (dado1 + dado2 > 6)
                    {
                        mayor6 += 1;
                    }
                    else if  (dado1 == dado2)
                    {
                        pares += 1;
                    }

                    

              }

                if (total >= 100)
                {
                    Console.WriteLine("Usted sacó cien puntos o más, ha ganado");
                    break;
                }
                else if ( pares >= 3)
                {
                    Console.WriteLine("Usted sacó tres pares consecutivos, ha ganado");
                    break;
                }
                else
                {
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                }
            }

              double Mayor6 = (mayor6 / totales) * 100;
               Console.WriteLine("El porcentaje de turnos en que sacó mas de 6 fue de: " + Mayor6+"%");
  

               Console.WriteLine("Su total fue de: " + total);

            

        }
    }
}
