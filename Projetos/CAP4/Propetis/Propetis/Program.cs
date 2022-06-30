using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propetis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 user = new Class1(01, "954.456.951.24", 8000);
            Class1 uuserr = new Class1();

            uuserr.saldo = double.Parse(Console.ReadLine());

            Console.WriteLine(user.Id);
            Console.WriteLine(user.Cpf);
            Console.WriteLine(uuserr.saldo);
        }
    }
}
