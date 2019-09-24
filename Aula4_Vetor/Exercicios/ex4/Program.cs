using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
        string[]ex1 = new string[15];
        string[]ex2 = new string[15];
        string[]ex3 = new string[30];

        for (int i = 0; i <= 14 ; i++ ){
            Console.Write("Digite uma palavra do primeiro vetor: ");
            ex1[i] = (Console.ReadLine());   
            ex3[i] = ex1[i];
        }
        for (int i = 0; i <= 14 ; i++ ){
            Console.Write("Digite uma palavra do segundo vetor: ");
            ex2[i] = (Console.ReadLine()); 
            ex3[i+15] = ex2[i];
        }

        for (int i = 0; i <= 29 ; i++ ){
            Console.WriteLine(ex3[i]);
        }
        }
    }
}
