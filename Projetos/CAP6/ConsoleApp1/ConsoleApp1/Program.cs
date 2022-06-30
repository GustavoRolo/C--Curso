using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                if (vect[quarto] == null)
                {
                    vect[quarto] = new Estudante(nome, email);
                }
                else
                {
                    Console.Write("Quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                    for (int x=0; vect[quarto] != null; x++)
                    {
                        Console.Write("Quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
