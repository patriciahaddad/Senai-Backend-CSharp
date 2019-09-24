using System;

namespace Verificador_CPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CNPJ: ");
            string CNPJ = Console.ReadLine();

            Console.WriteLine(ValidaCNPJ(CNPJ));
        }

        static bool ValidaCNPJ ( string cnpjusuario ){
            bool resultado = false;
            
            int[] v1 = {5, 4, 3, 2, 1, 9, 8, 7, 6, 5, 4, 3, 2};
            
            string cnpjCalculo = "";
            int resto = 0;
            int calculo = 0;
            
            string digito_v1 = "";
            string digito_v2 = "";


            // cpfusuario = cpfusuario.Trim('.'); // tirar os caracteres especiais do CPF
            // cpfusuario = cpfusuario.Trim('-');
                     
            cnpjCalculo = cnpjusuario.Substring(0,9); //selecionar parte do vetor

            for(int i = 0; i <= 8 ; i++){
                calculo += int.Parse(cpfusuario[i].ToString()) * v1[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(calculo > 9 ){
                digito_v1 = "0";
            } else{
                digito_v1 = calculo.ToString();
            }

            if( digito_v1 == cpfusuario[9].ToString()){
                resultado = true;
            }

                int[] v2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
                resto = 0;
                calculo = 0;

                cpfCalculo = cpfCalculo + calculo .ToString();
                calculo = 0;

                for(int i = 0; i <= 9 ; i++){
                    calculo += int.Parse(cpfusuario[i].ToString()) * v2[i];
                }

                resto = calculo % 11;
                calculo = 11 - resto;

                if(calculo > 9 ){
                    digito_v2 = "0";
                } else{
                    digito_v2 = calculo.ToString();
                }

                if( digito_v2 == cpfusuario[9].ToString()){
                    resultado = true;
                }


        return resultado;
        }
    }
}
