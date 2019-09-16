using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Digite um número inteiro");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2){
                Console.WriteLine("O maior número é o: " + num1);
            } else {
                Console.WriteLine("O maior número é o: " + num2);
            }
            
        }
    }
}
