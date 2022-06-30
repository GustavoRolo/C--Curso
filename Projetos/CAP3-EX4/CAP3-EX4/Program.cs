using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP3_EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 1:
            /*

            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
               
            }
            */

            //Exercicio 2:

            /*
            Console.Write("Qual a quantidade de número que deseja informar ?");
            int countnumber = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < countnumber; i++)
            {
                if(n >= 10 && n <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("IN: " + dentro + "\nOUT: " + fora);

            */

            //Exercicio 3:

            /*
            Console.Write("Quantos números deseja informar: ");
            int amounts = int.Parse(Console.ReadLine());
            double media = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double number = 0;
            for (int i = 0; i < amounts; i++)
            {
                Console.WriteLine($"Informe {amounts} valores reais: ");
                number = double.Parse(Console.ReadLine());

                if(i == 0)
                {
                    a = number;
                }
                else if (i == 1)
                {
                    b = number;
                }
                else
                {
                    c = number;
                }

            }
            media = ((a * 2) + (b * 3) + (c * 5))/10;
            Console.WriteLine(media.ToString("f2",CultureInfo.InvariantCulture));


            */

            //Exercicio 6:

            /*
             
            Console.WriteLine("Informe um número: ");

            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                int denominador = number % i;

                if(denominador == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //Exercicio 5:

            /*
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
            }

            */

        }
    } }
