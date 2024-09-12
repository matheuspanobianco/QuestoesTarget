using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a opção:");
            Console.WriteLine("Questão 1 - Verificar se o número pertence à sequência de Fibonacci");
            Console.WriteLine("Questão 2 - Contar a letra 'a' em uma string");
            Console.Write("Digite o número da opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                VerificarFibonacci();
            }
            else if (opcao == 2)
            {
                ContarLetraA();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        static void VerificarFibonacci()
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1, temp;

            bool pertence = false;

            while (a <= numero)
            {
                if (a == numero)
                {
                    pertence = true;
                    break;
                }

                temp = a;
                a = b;
                b = temp + b;
            }

            if (pertence)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }

        static void ContarLetraA()
        {
            Console.Write("Informe uma string: ");
            string texto = Console.ReadLine();

            int contador = 0;

            foreach (char c in texto)
            {
                if (c == 'a' || c == 'A')
                {
                    contador++;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine($"A letra 'a' aparece {contador} vez(es) na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' não foi encontrada na string.");
            }
        }
    }
}
