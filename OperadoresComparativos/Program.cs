// < > >= <= == !=
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Emit;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            bool c1 = a < 10;
            bool c2 = a > 10;
            bool c3 = a == 10;
            bool c4 = a <= 10;
            bool c5 = a >= 10;
            bool c6 = a != 10;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);


            Console.WriteLine("Digite um número:");
            int b = int.Parse(Console.ReadLine());
            
            if (b < 20){
                Console.WriteLine("Número menor do que 20!");
            } else if (b > 20){
                Console.WriteLine("Número maior do que 20!");
            } else {
                Console.WriteLine("Número igual a 20");
            }
        }
    }
}