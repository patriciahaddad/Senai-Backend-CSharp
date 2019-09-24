using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
double acumuladora = 0;
            double cont = 0;
            double salario  = 0;
            int funcionario = 1;

            Console.Write("Digite a quantidade de funcionários: ");
            funcionario = int.Parse(Console.ReadLine()); 
                
                do{
                    Console.Write("Digite o valor do salário: ");
                    salario = double.Parse(Console.ReadLine()); 

                    acumuladora += salario; 
                    cont++; //chamando o próximo número

                }
                while (cont < funcionario);
                 Console.WriteLine("Média dos salários: " + (acumuladora/cont));
        }
    }
}
