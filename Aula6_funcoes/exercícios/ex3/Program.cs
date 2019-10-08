using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
         {
            System.Console.WriteLine( MostrarInfo() );


            string nome, sobrenome;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            
            System.Console.WriteLine( MostrarInfo(nome, sobrenome) );


            string idade, peso, altura;

            Console.WriteLine("Digite seu idade: ");
            idade = (Console.ReadLine());
            
            Console.WriteLine("Digite seu peso: ");
            peso = (Console.ReadLine());
            
            Console.WriteLine("Digite seu altura: ");
            altura = (Console.ReadLine());

            Console.WriteLine( MostrarInfo(idade, peso, altura) );
        }
        
          static string MostrarInfo(){
            return "SENAI de Informática";         
        }
            static string MostrarInfo(string nome, string sobrenome){
            return nome + sobrenome;
        }
            
            static string MostrarInfo(string idade, string peso, string altura){
            return ("Sua idade é: " + idade + ". Seu peso é: " + peso + ". Sua altura é: " + altura);        
            //return $"{idade} {peso} {altura}";  
        }

    }
}
