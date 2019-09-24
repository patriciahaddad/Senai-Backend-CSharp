using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa, resultado;
            string final;
            Console.WriteLine("Digite a placa do seu carro");
            placa = Console.ReadLine();

            //Contamos a quantidade de caracteres de um elemento
            int caracteres = placa.Length;

            //Pegamos o último dígito
            final = placa.Substring(caracteres -1); //identifica que vamos contar da direita pra esquerda com o método substring (o -1 é pra dizer que é o último... em uma mesma função pode fazer de diferentes formas)

            if (final == "1" || final == "2"){
                resultado = "IF/ELSE - Seu rodízio é na segunda-feira.";
            } else if (final == "3" || final == "4"){
                resultado = "IF/ELSE - Seu rodízio é na terça-feira.";
            } else if (final == "5" || final == "6"){
                resultado = "IF/ELSE - Seu rodízio é na quarta-feira.";
            } else if (final == "7" || final == "8"){
                resultado = "IF/ELSE - Seu rodízio é na quinta-feira.";
            } else if (final == "9" || final == "0"){
                resultado = "IF/ELSE - Seu rodízio é na sexta-feira.";
            } else {
                resultado = "IF/ELSE - Placa inválida!";
            }
            Console.WriteLine(resultado);

            switch(final){
                case "1":
                resultado = "Switch - segunda-feira";
                break;

                case "2":
                resultado = "Switch - segunda-feira";
                break;

                case "3":
                resultado = "Switch - terça-feira";
                break;

                case "4":
                resultado = "Switch - terça-feira";
                break;

                case "5":
                resultado = "Switch - quarta-feira";
                break;
                
                case "6":
                resultado = "Switch - quarta-feira";
                break;

                case "7":
                resultado = "Switch - quinta-feira";
                break;

                case "8":
                resultado = "Switch - quinta-feira";
                break;

                case "9":
                resultado = "Switch - sexta-feira";
                break;
                
                case "0":
                resultado = "Switch - sexta-feira";
                break;

                default:
                resultado = "Switch - Entrada inválida! :(";
                break;
            }
                Console.WriteLine(resultado);
        }
        
    }
}
