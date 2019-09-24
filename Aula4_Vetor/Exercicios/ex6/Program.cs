using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] series1 = new int[10];
            int[] series2 = new int [10];
            int[] series3 = new int[10];

            for(int i = 0; i <= 9; i++) { //definir o tamanho do vetor (sempre começa com 0)
                Console.Write("Digite um número: ");
                series1[i] = int.Parse(Console.ReadLine()); //alimentando o primeiro vetor (serie1)
            }

            for(int i = 0; i <= 9; i++) {
                Console.Write("Digite outro número: ");
                series2[i] = int.Parse(Console.ReadLine()); 
            }

            for(int i =0; i <= 9; i++){
                series3[i]= series1[i] + series2[i];
            }
            
            for(int i =0; i <= 9; i++){
                Console.WriteLine(series3[i]);
            }
        }
    }
}
