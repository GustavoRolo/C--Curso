using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int resultado;

            resultado = maior(num1,num2, num3);

            Console.WriteLine(resultado);


        }

        static int maior (int a, int b, int c)
        {
            int m;

            if(a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
