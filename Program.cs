using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo à Calculadora!");
            Console.WriteLine("Opções:");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Divisão");
            Console.WriteLine("4-Multiplicação");
            Console.WriteLine("5-Sair");
            Console.WriteLine("------------------------------");
            Console.Write("Digite sua opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default:
                    {
                        Console.Write("Opção inválida! Tecle enter para voltar ao menu.");
                        Console.ReadKey();
                        Menu();
                        break;
                    }
            }


        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("A opção escolhida foi SOMA");
            Console.WriteLine("");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um segungo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float soma = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {soma}");
            Console.WriteLine("");
            Console.WriteLine("Tecle 'enter' para recomeçar...");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("A opção escolhida foi SUBTRAÇÃO");
            Console.WriteLine("");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um segungo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float sub = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {sub}");
            Console.WriteLine("");
            Console.WriteLine("Tecle 'enter' para recomeçar...");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("A opção escolhida foi DIVISÃO");
            Console.WriteLine("");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um segungo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float div = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {div}");
            Console.WriteLine("");
            Console.WriteLine("Tecle 'enter' para recomeçar...");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("A opção escolhida foi MULTIPLICAÇÃO");
            Console.WriteLine("");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um segungo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float mult = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {mult}");
            Console.WriteLine("");
            Console.WriteLine("Tecle 'enter' para recomeçar...");
            Console.ReadKey();
            Menu();
        }
    }
}
