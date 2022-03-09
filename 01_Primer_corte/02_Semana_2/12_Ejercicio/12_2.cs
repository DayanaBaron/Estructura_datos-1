using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cables = 0;
            int metrosca = 0;
            int valormca = 0;
            double DESCUENTO1 = 0.05;
            double DESCUENTO2 = 0.12;
            double DESCUENTO0 = 0; 
            double descuentot1 = 0; 
            double precioTC = 0;
            double facturatotal = 0;
            double descuentototal = 0; 

            Console.WriteLine("Digite la cantidad de cables");
            cables = int.Parse(Console.ReadLine());

            while (cables > 0)
            {
                Console.WriteLine("Digite la cantidad de metros de el cable");
                metrosca = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor del metro de el cable");
                valormca = int.Parse(Console.ReadLine());

                if (metrosca < 20 )
                {
                    precioTC = metrosca * valormca;
                    descuentot1 = DESCUENTO0;
                    precioTC = precioTC - descuentot1;
                }
                if (metrosca >= 20 && metrosca <= 40)
                {
                    precioTC = metrosca * valormca;
                    descuentot1 = metrosca * valormca * DESCUENTO1;
                    precioTC = precioTC - descuentot1;
                }
                if (metrosca > 40)
                {
                    precioTC = metrosca * valormca;
                    descuentot1 = metrosca * valormca * DESCUENTO2;
                    precioTC = precioTC - descuentot1;
                }
                Console.WriteLine("El descuento es: {0}", descuentot1);
                Console.WriteLine("El costo a pagar por el cable es: {0}", precioTC);
                facturatotal = facturatotal+precioTC;
                descuentototal = descuentototal + descuentot1; 
                cables--;
            }
            Console.WriteLine();
            Console.WriteLine("Factura");
            Console.WriteLine("El total a pagar por sus producto es: {0}", facturatotal);
            Console.WriteLine("El total de descuento: {0}", descuentototal);
        }
    }
}