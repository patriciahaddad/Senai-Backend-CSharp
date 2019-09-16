using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, despesa;
            Console.WriteLine("Digite o valor do seu salário");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da sua despesa");
            despesa = float.Parse(Console.ReadLine());

            if (salario > despesa){
            Console.WriteLine("Saldo final é superávit.");
            } else {
                Console.WriteLine("Saldo final é déficit.");
                
            }
            
            
        }
    }
}
