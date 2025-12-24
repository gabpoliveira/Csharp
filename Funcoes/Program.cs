/* 
-Representam um procesasmento que possui um significado.

-Vantagens: modularização, delegação e reaproveitamento.

-Dados de entrada e saída: Podem receber dados de entrada (parâmetros ou argumentos) e podem ou não retornar uma saída.

-Em orientação a objetos, funções em classes recebem o nome de "métodos".
*/
using System;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int maior;



            if (n1 > n2 && n1 > n3)
            {       
                maior = n1;
            } else if (n2 > n1 && n2 > n3){
                maior = n2;
            } else
            {
                maior = n3;
            }

                Console.WriteLine("Maior: " + maior);

                double resultado = Maior (n1, n2, n3);
                Console.WriteLine("Função: Número maior é: " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            } else if (b > a && b > c)
            {
                m = b;
            } else
            {
                m = c;
            }
            return m;
        }
    }
}