using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, media;
            string resultado;
            Console.WriteLine("Digite a primeira nota");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            n3 = float.Parse(Console.ReadLine());

            media = (n1 + n2 +n3)/3;

            if (media >= 6){
                resultado = "Aluno aprovado"; 
            } else if (media > 6 && media <= 4) {
                    resultado = "Aluno de recuperação";
                } else {
                     resultado = "Aluno reprovado";
                }
            Console.WriteLine($"Média: {media}. {resultado}.");
            }
        }
    }
