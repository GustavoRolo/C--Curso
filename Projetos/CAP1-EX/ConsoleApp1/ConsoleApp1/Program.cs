using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exerciocio 1

            /*  int n1, n2, resultado;
              Console.Write("Informe o primeiro número: ");
              n1 = int.Parse(Console.ReadLine());
              Console.Write("Informe o segundo número: ");
              n2 = int.Parse(Console.ReadLine());

              resultado = n1 + n2;

              Console.WriteLine("A soma dos número é = " + resultado); */

            //Exercicio 2

            /*double raio, area, pi;
            pi = 3.14159;
            Console.Write("Informe o raio do circulo: ");
            raio = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(raio);
            area = Math.Pow(raio, 2) * pi;

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture) ); */

            //Exercicio 3

            /*double diferenca;
            Console.Write("Informe 4 números: ");
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int D = int.Parse(vet[3]);

            diferenca = (A * B - C * D);

            Console.WriteLine($"Diferença : {diferenca}" );*/

            //Exercicio 4

            /*  int id;
              double salario;
              double horas;
              double valor_hora;

              Console.Write("Informe o ID do funcionario, saldo de horas e o valor por hora trabalhada : ");

              string[] vet = Console.ReadLine().Split();

              id= int.Parse(vet[0]);
              horas= int.Parse(vet[1]);
              valor_hora= int.Parse(vet[2]);

              salario = horas * valor_hora;

              Console.WriteLine($"ID do Funcionario: {id} \nSalário : {salario}"); */

            //Exercicio 5

              Console.WriteLine("Informe o código do prodto, unidade, valor: ");
              string[] vet = (Console.ReadLine().Split(' '));

              double total;
              int cod1 = int.Parse(vet[0]);
              int unid1 = int.Parse(vet[1]);
              double valor1 = double.Parse(vet[2]);

              int cod2 = int.Parse(vet[3]);
              int unid2 = int.Parse(vet[4]);
              double valor2 = double.Parse(vet[5]);

              total = (valor1 * unid1) + (valor2 * unid2);


              Console.WriteLine($"VALOR A PAGAR {total.ToString("F2", CultureInfo.InvariantCulture)}"); 


            //Exercicio 6
            /*
            Console.Write("De entrada de 3 valores: ");
            String[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);
            double triangulo, circulo, trapezio, retangulo, quadrado, pi =3.14159;

            triangulo = (a * c) / 2;
            circulo = pi * Math.Pow(2, c);
            trapezio = (a + b) / 2 * c;
            quadrado = Math.Pow(2, c);
            retangulo = a * b;

            Console.WriteLine($"Triangulo: {triangulo.ToString("F2")}\nCirculo: {circulo.ToString("F2")}\nTrapezio: {trapezio.ToString("F2")}\nRetangulo: {retangulo.ToString("F2")}\nQuadrado: {quadrado.ToString("F2")}");
            
            */


























        }
    }
}
