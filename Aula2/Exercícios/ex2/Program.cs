using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float ptotal;
            float resultado;
            Console.WriteLine("Qual é o preço total?");
            ptotal = float.Parse(Console.ReadLine());
            
            if (ptotal < 100){
                resultado = (ptotal-25);
                Console.WriteLine("O resultado é: " + resultado);
            }
        }
    }
}
