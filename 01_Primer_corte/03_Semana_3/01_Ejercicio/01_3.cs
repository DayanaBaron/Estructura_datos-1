using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class problema2
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0; 
            int t = 0;
            
            int z = 1;

            Console.WriteLine("\n Digite el tamaño del triangulo");
            t = int.Parse(System.Console.ReadLine()); 

                for (i =1; i <= t; i++)
                {
                  for (j = 1; j <= z; j++)
                  {
                    Console.Write("{0}", z);
                  }
                    Console.WriteLine(" ");
                    z = z+1;
            }
   
        }
    }
}