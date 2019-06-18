using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividendo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables

            float dividendo = 0.0f;
            float divisor = 0.0f;
            float resultado = 0.0f;

            Console.WriteLine("Cual es el dividendo ");
            dividendo = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("cual es el divisor ");
            divisor = Convert.ToSingle(Console.ReadLine());

            if(divisor!=0)
            {

                resultado = dividendo / divisor;

                Console.WriteLine("El resultado de dividir {0} entre {1} es {2}", dividendo, divisor, resultado);

            }
            
            Console.ReadKey();
            
        }
    }
}
