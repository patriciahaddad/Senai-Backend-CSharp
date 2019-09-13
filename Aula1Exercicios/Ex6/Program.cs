using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            float sfixo, divida, sobra;
            Console.WriteLine("Digite seu salário fixo");
            sfixo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da dívida");
            divida = float.Parse(Console.ReadLine());
            sobra = sfixo - divida;
            Console.WriteLine("Após pagar as dívidas, sobrará " + sobra + " reais do seu salário");
        }
    }
}
