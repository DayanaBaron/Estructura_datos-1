using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Problema5
{
    class program
    {
        static void Main(string[] args)

        {
            ArrayList lista1 = new ArrayList();
            ArrayList lista2 = new ArrayList();
            ArrayList lista3 = new ArrayList();
            ArrayList lista4 = new ArrayList();

            Console.WriteLine("lista 1");
            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);
            lista1.Add(4);
            lista1.Add(5);

            imprime(lista1);
            Console.WriteLine("lista 2");
            lista2.Add(1);
            lista2.Add(2);
            lista2.Add(3);
            lista2.Add(4);
            lista2.Add(5);

            imprime(lista2);
            Console.WriteLine("lista 3");
            lista3.Add(1);
            lista3.Add(2);
            lista3.Add(3);
            lista3.Add(4);
            lista3.Add(5);

            imprime(lista3);
            Console.WriteLine("lista 4");
            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);
            lista1.Add(4);
            lista1.Add(5);

            imprime(lista4);
            Console.WriteLine("la concatenacion de las 4 filas es: ");
            lista1.AddRange(lista2);
            lista1.AddRange(lista3);
            lista1.AddRange(lista4);
            imprime( lista1);

            static void imprime(ArrayList lista)
            {
                foreach (int i in lista)
                    Console.WriteLine("{0},",i);
                
            }

            Console.WriteLine("\n---------------");


        }
    }
}