using System;

namespace Aula6_funcoes
{
    class Program
    
    {
        static void Main(string[] args)
        {
            //Chamamos nossa primeira função
            Console.WriteLine( BomDia() );

            //Chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora ();

            //Chamamos nossa função que calcula a média
            double[] numeros = { 2, 5, 2, 8, 9, 5};
            Console.WriteLine( CalculaMedia (numeros));

           
           //Chamamos a função que calcula a soma
            double[] numero = {2, 5, 2, 8, 9, 5};
            Console.WriteLine (CalculaSoma (numeros));
        }
        /// <summary>
        /// Função que escreve Bom dia para o usuário
        /// </summary>
        /// <returns> Retorna Olá, bom dia! </returns>
        static string BomDia(){
            return "Olá, bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao"></param> um texto qualquer (sobrecarga de método)
        /// <returns>Saudação de acordo com o horário atual</returns>
        static string BomDia(string saudacao){
            int hora = DateTime.Now.Hour;

            if(hora <= 11 && hora >= 6){
                saudacao = "Bom Dia!";
            } else if (hora > 12 && hora <=18) {
                saudacao = "Boa tarde!";
            } else {
                saudacao = "Boa noite!";
            }
            
            return saudacao;
        }
        
        /// <summary>
        /// Retorna Data e Hora atual
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour);            
        }

        /// <summary>
        /// Retorna um número - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado com parâmetro</returns>
        
        static int BomDia (int numero){
            return numero;
        }


        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia (double[] valores){
            
            double resultado = 0;
            
            for(int i = 0; i < valores.Length; i++){  //usar o lenght para especificar que o for vai até o tamanho que for dado do vetor
            
            resultado += valores[i];
            resultado = resultado / valores.Length;
            }
            return resultado;
        } 

        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaSoma (double[] valores){
            
            double resultado = 0;
            
            for(int i = 0; i < valores.Length; i++){  //usar o lenght para especificar que o for vai até o tamanho que for dado do vetor
            
            resultado += valores[i];
            }
            return resultado;
        }
    }   
}
