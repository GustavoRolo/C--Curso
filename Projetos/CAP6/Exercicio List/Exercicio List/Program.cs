using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.Write("How many employees will be registered ? ");
            int employess = int.Parse(Console.ReadLine());


            for (int i = 0; i < employess; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Employee[] user = new Employee[employess];
                list.Add("ID: " + id + "\nName: " + name + "\nSalary: " + salary);
                user[i].Salary = salary;
                user[i].Name = name;
                user[i].Id = id;
            }

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage:");
            double percentage = double.Parse(Console.ReadLine());




        }
    }
}
