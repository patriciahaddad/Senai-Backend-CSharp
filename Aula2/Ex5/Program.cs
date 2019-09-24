using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;
            int pedido;
            Console.WriteLine("Escolha o número do seu pedido:");
            pedido = int.Parse(Console.ReadLine());

            switch(pedido){
                case 1:
                resultado = "Hambúrguer";
                break;

                case 2:
                resultado = "Cheese Salada";
                break;

                case 3:
                resultado = "Cheese buguer";
                break;

                case 4:
                resultado = "Cheese bacon";
                break;

                default:
                resultado = "Opção inválida";
                break;

        }
                 Console.WriteLine(resultado);

    }
    }
}
