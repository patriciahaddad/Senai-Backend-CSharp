using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Vetor = {1, 3, 5};
            Console.WriteLine( Soma(Vetor) );
        }
        static double Soma (double[] numeros){
            double soma = 0;

            foreach(double numero in numeros)
        {
            soma += numero;
        }
        return soma;
        }
    }
}
