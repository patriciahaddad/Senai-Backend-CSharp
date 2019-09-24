using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
          int atual = 0;
          int inicial = 0;
          int proximo = 1;
        
        for(int cont = 1; cont <= 9; cont++){
            atual = inicial + proximo;
            Console.WriteLine(atual);

            inicial = proximo;
            proximo = atual;
        }
        }        
                
    }
}
