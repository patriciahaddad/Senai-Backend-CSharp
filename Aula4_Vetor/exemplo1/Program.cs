using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] series1 = new string[10];
            string[] series2 = new string [10];

            for(int i = 0; i <= 9; i++) { //definir o tamanho do vetor (sempre começa com 0)
                Console.Write("Digite o nome de uma série: ");
                series1[i] = Console.ReadLine(); //alimentando o primeiro vetor (serie1)
            }

            for(int i = 0; i <= 9; i++) {
                series2[i] = series1[i]; //passar da serie1 para a serie2
            }

            for(int i =0; i <= 9; i++){
                Console.WriteLine(series2[i]);
            }

        }
    }
}
