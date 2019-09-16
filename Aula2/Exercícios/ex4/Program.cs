using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, resultado;
            Console.WriteLine("Digite o preço total");
            preco = double.Parse(Console.ReadLine());

            if (preco > 100 && preco < 1000){
                resultado = (preco - (0.15 * preco) );
                Console.WriteLine("O resultado com desconto é: " + resultado);
            } else {
                Console.WriteLine("Não terá desconto.");
            }

        }
    }
}
