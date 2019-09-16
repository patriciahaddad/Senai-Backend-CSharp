using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            float real, dol, cotacao;
            Console.WriteLine("Digite o valor em real");
            real = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do dólar");
            cotacao = float.Parse(Console.ReadLine());
            dol = ( real/ cotacao);
            Console.WriteLine("O valor em dólar é " +  dol);
        }
    }
}
