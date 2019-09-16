using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            Console.WriteLine("Digite sua idade:");
            id = int.Parse(Console.ReadLine());
            if (id> 3 && id < 6){
                Console.WriteLine("Você está na categoria Early Childhood");
            } else if (id >= 6 && id < 10){
                Console.WriteLine("Você está na categoria Everyone");
            } else if (id >= 10 && id < 13){
                Console.WriteLine("Você está na categoria Everyone 10+");
            } else if (id >= 13 && id < 17){
                Console.WriteLine("Você está na categoria Teen");
            } else if (id >= 17 && id < 18){
                Console.WriteLine("Você está na categoria Mature 17+");
            } else if (id >= 18){
                Console.WriteLine("Você está na categoria Adults Only 18+");
            }
        }
    }
}
