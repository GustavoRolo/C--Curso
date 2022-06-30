using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();

            Console.Write("Entre o número da conta: ");
            cliente.NumberAccount = long.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            cliente.Name = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char r = char.Parse(Console.ReadLine());

            if (r == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                cliente.Deposit = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            }
            else
            {

            }

            Console.Write("Dados da conta: ");
            Console.Write(cliente);
            Console.Write("Entre um valor para depósito: ");
            cliente.Deposit = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados: ");
            Console.Write(cliente);
            Console.Write("Entre um valor para saque: ");
            cliente.Saque = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write(cliente);



        }
    }
}
