// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147783748L;
            float n5 = 4.5f;
            double n6 = 4.51213213;
            string nome = "Gabriel Oliveira";
            object obj1 = "Alex";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n6.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //técnica do placeholder
            int idade = 34;
            double saldo = 10.454;
            string name = "Maria";

            Console.WriteLine("{0} tem {1} anos e R${2:F2} de saldo", name, idade, saldo);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo:F2}");

            //concatenação
            Console.WriteLine(name + " tem " + idade + " anos e tem saldo igual a R$" + saldo.ToString("F2"));
        }
    }
}