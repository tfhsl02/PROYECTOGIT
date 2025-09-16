using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- SISTEMA DE FACTURACIÓN GRUPO2 ----");

            //INGRESO DE DATOS

            decimal pbase, pcondescuento=0, IGV, pfinal;
            int tipo; // 1. frecuente - 2.nuevo - 3.corporativo

            Console.WriteLine("Ingresar nombre del producto");
            string nomproducto = Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto");
            pbase = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar tipo de cliente" + "\n1.frecuente \n2.nuevo \n3.corporativo");
            tipo = int.Parse(Console.ReadLine());

            //USO DE DESCUENTOS
            decimal descuento = 0;
            switch (tipo)
            {

                case 1: 
                    descuento=0.10M;break;
                case 2: 
                    descuento=0;break;
                case 3: 
                    descuento=0.15M;break;
                default:Console.WriteLine("ingrese una opción válida");return;

            }

            //IGV Y PRECIO FINAL
            pcondescuento = pbase - (pbase * descuento);
            IGV = pcondescuento * 0.18M;
                pfinal = pcondescuento + IGV;
            //FACTURACIÓN
            Console.WriteLine($"Nombre del producto: {nomproducto}");
            Console.WriteLine($"Precio del producto: S/ {pbase:F2}");
            Console.WriteLine($"Descuento aplicado: {pcondescuento:F2}");
            Console.WriteLine($"IGV (18%): S/ {IGV:F2}");
            Console.WriteLine($"Precio final a pagar: S/ {pfinal:F2}");


            Console.ReadKey();






        }
    }
}
