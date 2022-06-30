using System;
using System.Globalization;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\nInforme o seu gênero: ");
            char genero = char.Parse(Console.ReadLine());
            Console.Write("\nInforme a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o seu salda: ");
            double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           

            Console.WriteLine("\nCONCATENAÇÃO\n");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Gênero: " + genero);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Saldo: " + saldo.ToString("F4"));
            Console.WriteLine("Saldo com ponto: " + saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("PLACE HOLDER\n");
            Console.WriteLine("{0} é do gênero {1} possui {2} anos e tem em sua conta o saldo de {3:F2}", nome, genero, idade, saldo);
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("INTERPOLAÇÃO\n");
            Console.WriteLine($"{nome} tem {idade} anos é do gênero {genero} e possui o saldo de {saldo:F2} reais");

            Console.WriteLine("=================================================");
            
             int a = 55;
            double b = a;
          

            Console.WriteLine(a);
           



        }
    }
}