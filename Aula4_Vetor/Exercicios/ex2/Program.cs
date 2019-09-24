using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
        int[]ex1 = new int[10];
        int[]ex2 = new int[10];
        int[]ex3 = new int[20];

        for (int i = 0; i <= 9 ; i++ ){
            Console.Write("Digite o número do primeiro vetor: ");
            ex1[i] = int.Parse(Console.ReadLine());   
            ex3[i] = ex1[i];
        }
        for (int i = 0; i <= 9 ; i++ ){
            Console.Write("Digite o número do segundo vetor: ");
            ex2[i] = int.Parse(Console.ReadLine()); 
            ex3[i+10] = ex2[i];
        }

        for (int i = 0; i <= 19 ; i++ ){
            Console.WriteLine(ex3[i]);
        }

    }
}
}