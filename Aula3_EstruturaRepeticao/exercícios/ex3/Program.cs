using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
        int n;

        Console.WriteLine("Digite um número: ");
        n = int.Parse(Console.ReadLine());
        for(int cont = 0 ; cont <= n ; cont ++) {

                if(cont % 5 ==0){

                    Console.WriteLine(cont);
                }
            }
          
        }
        
    }
    
}
