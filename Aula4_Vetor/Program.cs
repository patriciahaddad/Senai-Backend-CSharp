using System;

namespace Aula4_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {            
            double[]media = new double[10];

            for(int i = 0; i <= 9; i++ ){
            
            Console.Write("Digite uma média: ");
            media[i] = double.Parse( Console.ReadLine() );

                Console.WriteLine(media[3]);
            }
            for(int i = 0; i <= media.Length -1; i++ ){ //usar o length para delimitar a quantidade de índices que eu tenho (caso não lembre a quantidade)
                Console.WriteLine("Média: " + media[i]);

            }
        }
    }
}
