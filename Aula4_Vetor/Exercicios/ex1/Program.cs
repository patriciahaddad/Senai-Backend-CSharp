using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {   double conta;
            int[]ex1 = new int[10];

        for (int i = 0; i <= 9 ; i++ ){
            Console.Write("Digite o número: ");
            ex1[i] = int.Parse(Console.ReadLine());
        }

            conta = ex1[9] * 5;
            Console.Write(conta);

            Console.WriteLine();

            for (int i = 0; i <= 9 ; i++ ){
                Console.Write(ex1[i]);
        }  
        }
    }
}
