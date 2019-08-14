using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            Console.WriteLine("Bienvenido a BlackJack");

            int carta1 = aleatorio.Next(1, 10);
            Console.WriteLine("Su primera carta es: " + carta1);
            int carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("Su segunda carta es: " + carta2);

            int suma = carta1 + carta2;
            Console.WriteLine("Lleva un total de: " + suma);
            int nuevaCarta = 0;

            String continuar = "s";
            while (continuar == "s" && suma <= 21)
            {

                Console.WriteLine("¿Desea pedir otra carta? (s/n)");
                continuar = Console.ReadLine();
                Console.WriteLine("");
                if (continuar == "s")
                {
                    nuevaCarta = aleatorio.Next(1, 10);
                    Console.WriteLine("Su nueva carta es: " + nuevaCarta);
                    suma = suma + nuevaCarta;
                    Console.WriteLine("Su nuevo total es de: " + suma);

                }
                if (suma > 21)
                {
                    Console.WriteLine("Eliminado");
                    continuar = "n";

                }

                Console.WriteLine("Su total fue de: " + suma);
                Console.WriteLine("Gracias por jugar");

            }
        }
    }
}
