
using System.Globalization;
Console.WriteLine("1 - Estrutura While");
Console.WriteLine("Digite um número");
double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//while
while (number >= 0)
{
    double root = Math.Sqrt(number);
    Console.WriteLine("Raiz: " + root.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("Deseja passar para a estrutura for?(s/n)");
    string finish = Console.ReadLine();
    if(finish == "s"){
        break;
    } else if (finish == "n") {
        Console.WriteLine("Continuando...");
    } else
    {
        Console.WriteLine("Comando não identificado! Continuando...");
    }
    Console.WriteLine("Digite outro número:");
    number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
};

while (number < 0)
{
    Console.WriteLine("Número negativo! Passando para a próxima etapa...");
    break;
};

//for
Console.WriteLine("2 - Estrutura for");
Console.WriteLine("Quantos números inteiros você vai digitar?");
int n = int.Parse(Console.ReadLine());
int soma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Valor #{0}: ", i);
    int valor = int.Parse(Console.ReadLine());
    soma += valor;
}

Console.WriteLine("A soma dos valores é:" + soma);