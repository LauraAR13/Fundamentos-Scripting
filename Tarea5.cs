using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_tarea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.WriteLine("Ingrese 1 si su contrato es independiente o 2 si es dependiente");
            double contrato = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de su salario mensual");
            double salario = double.Parse(Console.ReadLine());
            //Declarar variables 
            double cotizacion;
            double eps;
            double pension;
            double arl = 0;
            double deduccion = 0;
            double bonificacion = 0;
            int claseRiesgo = 0;
            double smmlv = 828116;
            //Calcular base de cotizacion
            cotizacion = salario * 0.4;
            if (cotizacion < smmlv) cotizacion = smmlv;

            //Calcular las deducciones de los salarios dependiendo de su contrato
            switch (contrato)
            {
                case 1://caso del contrato independiente
                    Console.WriteLine("Ingrese su clase de riesgo del 1 al 5");
                    claseRiesgo = int.Parse(Console.ReadLine());
                    pension = cotizacion * 0.16;
                    eps = cotizacion * 0.12;
                    switch (claseRiesgo) //Switch para el calculo del arl
                    {
                        case 1: arl = cotizacion * 0.00522;
                            break;
                        case 2: arl = cotizacion * 0.01044;
                            break;
                        case 3: arl = cotizacion * 0.02436;
                            break;
                        case 4: arl = cotizacion * 0.04350;
                            break;
                        default: arl = cotizacion * 0.06960;
                            break;
                            
                    }
                    deduccion = pension + eps + arl;
                    break;

                default: //El unico otro caso posible es el contrato dependiente 
                    pension = cotizacion * 0.04;
                    eps = cotizacion * 0.04;
                    deduccion = pension + eps;
                    bonificacion = salario;
                    break;


            }
            // Salida de datos (salarios reales)
            Console.WriteLine("Su salario mensual real es de: ");
            double salarioMensual = salario - deduccion;
            Console.WriteLine(salarioMensual);

            Console.WriteLine("Su salario anual real es de: ");
            double salarioAnual = (salarioMensual * 12) + bonificacion;
            Console.WriteLine(salarioAnual);
            Console.ReadLine();


                
                
            
            
        }
    }
}
