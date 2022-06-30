using System;
using System.Globalization;

namespace EX_ConsoleWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador", produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0, preco2 = 650.50, media = 53.234567;

            //PLACE HOLDER
            Console.WriteLine("{0}, cujo o preço é $ {1}\n{2}, cujo preço é $ {3}\n\nRegistro: {4} anos de idade, código {5} e gênero: {6}\n\nMedida com oito casas decimais: {7}\nArredondado (três casas decimais): {8:F2}\nSeparador decimal invariant culture:{9}", produto1, preco1, produto2, preco2, idade, codigo, genero, media, media, media.ToString(CultureInfo.InvariantCulture)) ;

            //INTERPOLAÇÃO

            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1}\n{produto2}, cujo o preço é $ {preco2}\n\nRegistro: {idade}, código {codigo} e gênero: {genero}\n\nMedida com oito casas decimais: {media},\nArredondado (três casas decimais): {media:F2}\nSeparador dicimal invariant culture: {media.ToString(CultureInfo.InvariantCulture)}");

            //CONCATENAÇÃO
            Console.WriteLine(produto1 + " cujp p preço é $ " + preco1 + "\n" + produto2 + "cujo o preço é $ " + preco2 + "\n\n" + "Registro: " + idade + ", código " + codigo + "e gênero: " + genero + "\n\nMedida com oito casas decimais: " + media + "\nArrendondado (três casas decimais): " + media.ToString("F3") + "\nSeparador decimal invariant cultural " + media.ToString(CultureInfo.InvariantCulture));
        }

    }
}
