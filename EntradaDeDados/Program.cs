Console.WriteLine("Digite algo");
string frase = Console.ReadLine();

Console.WriteLine("Você digitou " + frase);
Console.WriteLine("Digite 3 cores");
string s = Console.ReadLine();
string[] v = s.Split(' ');
string a = v[0];
string b = v[1];
string c = v[2];

Console.WriteLine("Cor 1: "+ a + " Cor 2: " + b + " Cor3: " + c);
Console.WriteLine("Cor 2 " + v[1]);

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Sua idade é "+ idade);

Console.WriteLine("Digite uma letra");
char ch = char.Parse(Console.ReadLine());
Console.WriteLine("Você digitou a letra "+ ch);
Console.WriteLine("Dige um número decimal");
double n2 = double.Parse(Console.ReadLine());
Console.WriteLine("O número que você digitou é "+ n2);

//Exercício
Console.WriteLine("Qual seu nome?");
string nome = Console.ReadLine();
Console.WriteLine("Quantos anos você tem?");
int anos = int.Parse(Console.ReadLine());
Console.WriteLine("M ou F?");
char sexo = char.Parse(Console.ReadLine());
Console.WriteLine("Insira um número decimal");
double numb = double.Parse(Console.ReadLine());

Console.WriteLine("Olá, "+ nome +"! " + "Sua idade é "+ anos + " anos" + " Seu sexo é: " + sexo + " e o número decimal que você digitou é: " + numb);
