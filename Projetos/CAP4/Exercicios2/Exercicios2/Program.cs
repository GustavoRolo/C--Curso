using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Exercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //Exercicio 1:

            Retangulo  retangulo = new Retangulo();

            Console.Write("Enter heigth: ");

            retangulo.heigth = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            retangulo.width = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {retangulo.Area()}\nDiagonal: {retangulo.Diagonal()}\nPerimeter: {retangulo.Perimeter()}");
        
            */

            //Exercicio 2:

            /*
             
            Funcionario funcionario = new Funcionario();
            double percentage;

            Console.Write("Enter the employee's name: ");
            funcionario.name = Console.ReadLine();

            Console.Write("Enter the gross salary: ");
            funcionario.grooswage = double.Parse(Console.ReadLine());

            Console.Write("Enter tax: ");
            funcionario.tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"Employee {funcionario.name}, $ {funcionario.NetWage().ToString("F2",CultureInfo.InvariantCulture)}");

            Console.Write("Enter percentage to increase salary: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.UpWage(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);

            */

            //Exercicio 3:

            /*
            Alunos aluno = new Alunos();
            
            Console.Write("Enter name: ");
            aluno.name = Console.ReadLine();

            Console.Write("Enter the 3 student notes: ");
            string[] vet = Console.ReadLine().Split(' ');
            aluno.nota1 = double.Parse(vet [0]);
            aluno.nota2 = double.Parse(vet [1]);
            aluno.nota3 = double.Parse(vet [2]);

            Console.WriteLine("Nota Final: " + aluno.Soma());
            Console.WriteLine(aluno.Resultado());
            */



            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
