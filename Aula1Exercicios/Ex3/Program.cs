using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float sfixo, tvenda;
            double conta;
            Console.WriteLine("Digite o valor do salário fixo");
            sfixo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade total das vendas");
            tvenda = float.Parse(Console.ReadLine());
            conta = (0.5 * tvenda) + sfixo ;
            Console.WriteLine("Seu salário este mês será de " + conta);
        }
    }
}
