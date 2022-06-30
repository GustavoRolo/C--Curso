using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_em_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Conversão

            int x = 100;
            int z = 2;
            float w = 2.5f;

            x = (int)w;

            Console.WriteLine(z);

            x = 5;

            Console.WriteLine((double)x / z);

            //Entrada de dados

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            //Baskara

            double b = 9, a = 2, c = 5;
            double delta = Math.Pow(b, 2.0) - a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);

        }
    }
}
