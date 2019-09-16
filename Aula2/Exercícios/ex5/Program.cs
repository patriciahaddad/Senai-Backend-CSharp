using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite um número inteiro");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro número inteiro");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o último número inteiro");
            n3 = int.Parse(Console.ReadLine());

            if (n1>n2 && n1>n3) {
                Console.WriteLine("O maior número é o: " + n1);
            } else if (n2>n3){
                Console.WriteLine("O maior número é o: " + n2);
            }      else {
                    Console.WriteLine("O maior número é o: " + n3);
            }
}                
            }
}
