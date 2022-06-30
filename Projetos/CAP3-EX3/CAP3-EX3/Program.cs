using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP3_EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 :
            /*
            int senha = 2002;

            Console.Write("Infome a senha do usuário: ");
            int usersenha = int.Parse(Console.ReadLine());

            while(usersenha != senha)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Infome a senha do usuário: ");
                usersenha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");

            */

            //Exercicio 2:

            /*

            Console.Write("Informe o valor de x e do y: ");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);


            while(x != 0 && y != 0)
            {
               
                if(x < 0 && y > 0)
                {
                    Console.Write("Primeiro Quadrante");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                Console.Write("Informe o valor de x e do y: ");
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

            */

            //Exercicio 3:

            Console.Write("Informe o tipo de combustivel [1]Álcool [2]Gasolina [3]Disel [4]Fim :");

            int combustivel = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, disel = 0, fim = 0;

            while (combustivel != 4)
            {
                if (combustivel == 1)
                {
                    alcool += 1;
                }
                else if (combustivel == 2)
                {
                    gasolina += 1;
                }
                else if(combustivel == 3)
                {
                    disel += 1;
                }
                else
                {
                    Console.WriteLine("Opção invalida digite novamente!");
                }
             
                Console.Write("Informe o tipo de combustivel [1]Álcool [2]Gasolina [3]Disel [4]Fim :");

                combustivel = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($" Álcool: {alcool}\nGasolina: {gasolina}\nDisel: {disel}");


        }
    }
}
