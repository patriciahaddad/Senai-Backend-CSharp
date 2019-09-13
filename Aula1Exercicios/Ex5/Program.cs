using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            float sfixo, tvenda;
            double sfinal;
            Console.WriteLine("Digite o nome do vendedor");
            vendedor = Console.ReadLine();
            Console.WriteLine("Digite o valor do salário fixo");
            sfixo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total das vendas efetuadas em dinheiro");
            tvenda = float.Parse(Console.ReadLine());
            sfinal = (0.10 * tvenda) + sfixo ;
            Console.WriteLine("O nome do vendedor é " + vendedor + ", seu salário fixo é " + sfixo + " e o salário final do mês é " + sfinal);    
        }
    }
}
