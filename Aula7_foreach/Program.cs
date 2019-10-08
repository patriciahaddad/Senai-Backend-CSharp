using System;

namespace Aula7_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] v1 = {"A", "B", "C"};

            //Laço FOREACH (para cada) - no C# serve apenas para imprimir as informações que estão dentro dele - exemplo: quando usamos o for apenas para declarar que será impresso na tela, para não colocar outro contador, usamos o foreach

            foreach(string letra in v1){
                Console.WriteLine(letra);

            }
        }
    }
}
