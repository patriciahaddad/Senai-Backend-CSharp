using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco, acres, conta;
            Console.WriteLine("Digite o valor do produto: ");
            preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do percentual de acréscimo, apenas números: ");
            acres = float.Parse(Console.ReadLine());
            conta = ( (acres/100) * preco) + preco;
            Console.WriteLine("O valor do produto com o acréscimo é " + conta);
        }
    }
}
