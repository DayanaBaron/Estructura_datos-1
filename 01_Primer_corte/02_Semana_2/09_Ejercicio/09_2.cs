using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double areatriangulo, areacirculo;
            double bases = 0;
            double altura = 0;
            double PI = 3.1415;
            double radio = 0;
            double resultado = 0;
            char opcion;

            Console.WriteLine("T/t:,Area del tringulo");
            Console.WriteLine("C/c:,Area del circulo");
            Console.WriteLine("el area que quiere realizar es");
            opcion = Console.ReadKey().KeyChar;


            switch (opcion)
            {
                case 't':
                case 'T':
                    Console.WriteLine();
                    Console.WriteLine("digite la base");
                    bases = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite la altura");
                    altura = double.Parse(Console.ReadLine());
                    resultado = (bases * altura * 2);
                    break;

                case 'c':
                case 'C':
                    Console.WriteLine();
                    Console.WriteLine("digite el radio");
                    radio = double.Parse(Console.ReadLine());
                    resultado = (PI * radio * radio);
                    break;
                    Console.WriteLine("el area es{0}", resultado);
            }
            Console.WriteLine("el area es: {0}", resultado);
        }
    }
}