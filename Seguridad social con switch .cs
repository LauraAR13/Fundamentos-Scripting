using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad_social_con_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese el valor de su salario mensual: ");
            double salarioInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si su contrato es de tipo dependiente o 2 si es independiente: ");
            int contrato = int.Parse(Console.ReadLine());
            //Declaración de variables 

            double deduccion = 0;
            double arl = 0;
            double pension = 0;
            double eps = 0;
            double bonificacion = 0;
            double baseCotizacion = salarioInicial * (0.4);

            double slmmlv = 828116;

            // Condicionales 
            if (baseCotizacion < 828116) baseCotizacion = slmmlv;

            switch (contrato)
            { case 2:
                Console.WriteLine("Por favor ingrese un número del 1 al 5 equivalente a la clase de riesgo: ");
                int claseRiesgo = int.Parse(Console.ReadLine());
                    eps = baseCotizacion * 0.125;
                    pension = baseCotizacion * 0.16;
              switch (claseRiesgo)
              {
                        //Cálculo de las deducciones

                        case 1:  arl = baseCotizacion * 0.00522;
                            break;
                        case 2:  arl = baseCotizacion * 0.01044;
                            break;
                        case 3:   arl = baseCotizacion * 0.02436;
                            break;
                        case 4:   arl = baseCotizacion * 0.04350;
                            break;
                        default: arl = baseCotizacion * 0.0690;
                            break;
               }
              deduccion = (eps + arl + pension);
                    break;



                default:
            
                eps = baseCotizacion * 0.04;
                pension = baseCotizacion * 0.04;
                bonificacion = salarioInicial;
                deduccion = (eps + pension);
                    break;

            }
            // Salida de datos 
            double salarioMensual = salarioInicial - deduccion;
            Console.WriteLine("Su salario mensual real es de: " + salarioMensual);
            double salarioAnual = salarioMensual * 12 + bonificacion;
            Console.WriteLine("Su salario anual es de: " + salarioAnual);
        }
    }
}
