using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Olá, bem-vindo! Digite um número:");
            num1 = int.Parse(Console.ReadLine());
            int conta;
            conta = num1 * 3;
            Console.WriteLine("A multiplicação do seu número por 3 é " + conta);

        }
    }
}
