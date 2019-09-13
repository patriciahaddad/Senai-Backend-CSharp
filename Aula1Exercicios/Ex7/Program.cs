using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double passageiros, total;
            Console.WriteLine("Digite a quantidade de passageiros:");
            passageiros = double.Parse(Console.ReadLine());
            total = passageiros * 4.30;
            Console.WriteLine("O valor total é " + total);
        }
    }
}
