using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 0;
            int maior = -99999;
            int[] exercicio7 = new int[10];

            for(int i = 0; i <= 9; i++) { 
                Console.Write("Digite um número: ");
                exercicio7[i] = int.Parse(Console.ReadLine()); 
            
                if( maior < exercicio7[i]) {
                    posicao = i;
                    maior = exercicio7[i];      
                    
                    Console.WriteLine(maior + "o índice é: " posicao);   
     
            }            
            }
    }
}
}
