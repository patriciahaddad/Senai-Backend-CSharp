using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaiorNumero());
        }
            public double MaiorNumero (double [] valores){

                double maior = 0;

            for(int i = 0; i < valores.Length; i++ ){
                if(valores[0] < 0 ){
                    maior = valores[0];
                }

                if(valores[i] > maior){
                    maior = valores[i];
                }
            }
            return maior;
        }
    }
}
