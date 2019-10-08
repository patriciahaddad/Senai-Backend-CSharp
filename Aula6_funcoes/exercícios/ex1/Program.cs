using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        { 
            try{
    
            double produto, desconto; 

            Console.WriteLine("Digite o valor do produto: ");
            produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do desconto: ");
            desconto = double.Parse(Console.ReadLine().Replace("%", ""));

            Console.WriteLine(CalculaDesconto(produto, desconto));  


        } catch (Exception ex){
            //Mostramos a exceção da regra - erro gerado na aplicação
            
            Console.WriteLine("Ops :( Os dados devem ser numéricos" + ex);
        }
          
           /// <summary>
           /// Calcular o desconto de um produto 
           /// </summary>
           /// <param name="produto">Valor do produto</param>
           /// <param name="desconto">Valor do desconto</param>
           /// <returns>Valor do produto com desconto</returns>
            static double CalculaDesconto (double produto, double desconto){ //é importante manter a mesma ordem
            
            produto = produto - ((desconto/100)*produto);

            return produto;  
            // poderia colocar só return produto - (desconto/100)*produto;

        
            }
        }
    }
}