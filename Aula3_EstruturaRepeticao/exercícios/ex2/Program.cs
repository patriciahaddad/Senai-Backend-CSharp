using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int cont, tabuada;
        int numero;

        Console.Write("Digite um número para fazer a taboada: ");
        numero = int.Parse(Console.ReadLine());

        for(cont = 0; cont <= 10; cont ++ ){
        
            tabuada = numero * cont;
        {
            Console.WriteLine( numero + " X " + cont + " = " + tabuada );        
            }
        }
       
}
    }
}