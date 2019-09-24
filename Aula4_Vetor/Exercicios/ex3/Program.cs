using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string [12];

            for(int i = 0; i <= 11; i++) { //definir o tamanho do vetor (sempre começa com 0)
                Console.Write("Digite o nome do produto, a cor e o preço: ");
                produto[i] = Console.ReadLine(); //alimentando o primeiro vetor (serie1)      
    }

             for(int i = 0; i <= 11; i++) 
             Console.WriteLine(produto[i]);

}
}
}