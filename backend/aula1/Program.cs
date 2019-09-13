using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somente declaramos, sem atribuir valor
            int num1;

            //Declarar e atribuir valor
            int num2 = 5;
            
            //Declarar diversas variáveis do mesmo tipo (posso ou não atribuir valor)
            int num3, num4, num5;
            
            //Variável do tipo decimal/real
            float media;
            
            //Variável do tipo lógico (booleana) 
            bool resultado = false;

            //Variável do tipo texto (caracteres)
            string nomeAluno;

            //Escrever em uma linha, quebrando-a 
            Console.WriteLine("Bem-vindos à nossa primeira aplicação!");

            //Quebra de linha
            Console.WriteLine();

            //Continua escrevendo na mesma linha - tira o line da segunda parte
            Console.Write("Digite");
            Console.Write(" seu nome:");

            //Capturo o dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            //Concatenação
            Console.WriteLine(nomeAluno + ", agora digite a sua primeira nota:");

            //Converter o texto capturado para o tipo inteiro
            num3 = int.Parse(Console.ReadLine());

            //Interpolação
            Console.WriteLine($"Sua primeira nota é {num3} ");

            Console.WriteLine("Digite sua segunda nota");

            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota");

            num5 = int.Parse(  Console.ReadLine() );

            media = (num3 + num4 + num5) / 3;

            Console.WriteLine("Sua média é " + media);













        }
    }
}
