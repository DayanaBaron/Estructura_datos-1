using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio1
{
    class program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sf = 0;
            int sm = 0;
            int i = 0;
            int c1 = 0;
            int c2 = 0; 
            int cant_mujeres = 0;
            int cant_hombres = 0;
            int suma1 = 0;
            int suma2 = 0; 
            int opcion;
            Console.WriteLine("digite la cantidad de empleados");
            num = int.Parse(System.Console.ReadLine());

            while (i < num)
            {
                Console.WriteLine("1: femenino");
                Console.WriteLine("2: masculino");
                Console.WriteLine("El sexo del empleado es");
                opcion = int.Parse(System.Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("digite su sueldo");
                        sf = int.Parse(System.Console.ReadLine());
                        if (sf >= 1000000)
                        {
                            c1 = c1 + 1;
                            suma1 = suma1 + sf;
                        }
                        else
                        {
                            Console.WriteLine("Su salario es menor a 1000000");
                        }
                        cant_mujeres = cant_mujeres + 1;
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("digite su sueldo");
                        sm = int.Parse(System.Console.ReadLine());
                        if (sm >0 && sm <= 900000)
                        {
                            c2 = c2 + 1;
                            suma2 = suma2 + sm;
                        }
                        else
                        {
                            Console.WriteLine("Su salario es mayor a 900000");
                        }
                        cant_hombres = cant_hombres + 1;
                        break;
                }
     
                i++;
            }

            Console.WriteLine(" La suma de los salarios de las mujeres es: {0}", suma1);
            Console.WriteLine(" La suma de los salarios de los hombres es: {0}", suma2);
            Console.WriteLine(" La cantidad de mujeres son: {0}", cant_mujeres);
            Console.WriteLine(" La cantidad de hombres son: {0}", cant_hombres);
            Console.WriteLine(" La cantidad de mujeres que ganan mas de 1000000: {0}", c1);
            Console.WriteLine(" La cantidad de hombres que ganan menos de 900000: {0}", c2);

        }
    }
}