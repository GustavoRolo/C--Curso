
//Exerciico 1:
/*
Console.Write("Digite um número inteiro: ");

int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine($"O número {number} é  negativo.");
}
else if (number >= 0)
{
    Console.WriteLine($"O número {number} é par.");
}
else
{
    Console.WriteLine($"Caracter invalido!");
}
*/

//Exercicio 2:

/*
Console.WriteLine("Digite um número: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"O número {number} é par!");
}
else if (number % 2 == 1 || number % 2 == -1)
{
    Console.WriteLine($"O número {number} é impar!");
}
else
{
    Console.WriteLine("Caracter Invalido!");
}
*/

//Exercicio 3:

/*
Console.WriteLine("Informe 2 números: ");

String[] vet = Console.ReadLine().Split(' ');
int numb1 = int.Parse(vet[0]);
int numb2 = int.Parse(vet[1]);

if (numb1 % numb2 == 0 || numb2 % numb1 == 0)
{
    Console.WriteLine($"Os números {numb1} e {numb2} são multiplos.");
}
else
{
    Console.WriteLine($"Os números {numb1} e {numb2} não são multiplos.");
}

*/

//Exercicio 4:
/*
string[] vet = Console.ReadLine().Split(' ');

int start = int.Parse(vet[0]);
int end = int.Parse(vet[1]);
int time;

if (start < end)
{
    time = end - start;
    Console.WriteLine($"O jogo durou {time} horas!");
}
else if (start > end)
{
    time = start - end;
    time = 24 - time;

    Console.WriteLine($"O jogo durou {time} horas!");
}
else
{
    Console.WriteLine($"O jogo durou 24 horas!");
}
*/

//Exercicio 7:
/*
using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

double x = double.Parse(vet[0]);
double y = double.Parse(vet[1]);

if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");

}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
else if (x == 0)
{
    Console.WriteLine("Posição eixo Y");
}
else if (y == 0)
{
    Console.WriteLine("Posição eixo X");
}
else
{
    Console.WriteLine("Posisão de origem!");
}
*/

//Exercicio 8:

using System.Globalization;

double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double imposto;
if (salario <= 2000.0)
{
    imposto = 0.0;
}
else if (salario <= 3000.0)
{
    imposto = (salario - 2000.0) * 0.08;
}
else if (salario <= 4500.0)
{
    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
}
else
{
    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}

if (imposto == 0.0)
{
    Console.WriteLine("Isento");
}
else
{
    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}