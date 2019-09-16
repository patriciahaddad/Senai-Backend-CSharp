using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar as notas que utilizaremos
            double n1, n2, n3, media;

            //Capturamos a primeira nota
            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            //Capturamos a segunda nota
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            //Capturamos a terceira nota
            Console.Write("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            //Calculamos a média
            media = (n1 + n2 + n3)/3;

            //Verificar se a média do aluno é maior ou igual a 6
            if (media >= 6) {
                Console.WriteLine($"Média: {media}. Aluno aprovado!" );
            } else {
                Console.WriteLine($"Média: {media}. Aluno reprovado!");
            }
        }
    }
}
