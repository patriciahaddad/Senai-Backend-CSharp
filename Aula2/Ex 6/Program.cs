using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, resultado;
            int planeta;
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o planeta escolhido:");
            planeta = int.Parse(Console.ReadLine());
            
            switch(planeta){
                case 1:
                resultado = (peso/10) * 0.37 ;
                Console.WriteLine("Seu peso no planeta Mercúrio é: " + resultado);
                break;

                case 2:
                resultado = (peso/10) * 0.88 ;
                Console.WriteLine("Seu peso no planeta Vênus é: " + resultado);
                break;

                case 3:
                resultado = (peso/10) * 0.38 ;
                Console.WriteLine("Seu peso no planeta Marte é: " + resultado);
                break;

                case 4:
                resultado = (peso/10) * 2.64 ;
                Console.WriteLine("Seu peso no planeta Júpiter é: " + resultado);
                break;

                case 5:
                resultado = (peso/10) * 1.15 ;
                Console.WriteLine("Seu peso no planeta Saturno é: " + resultado);
                break;

                case 6:
                resultado = (peso/10) * 1.17 ;
                Console.WriteLine("Seu peso no planeta Urano é: " + resultado);
                break;

                default:
                Console.WriteLine("Indefinido");
                break;
        }

    }
}
}
