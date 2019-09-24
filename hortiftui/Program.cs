using System;

namespace hortiftui {
    class Program {
        static void Main (string[] args) {
            string[] produto = new string[10];
            double[] preco = new double[10];
            double total = 0;

            string sair = "";

            while (sair != "0") {

                Console.WriteLine ("Olá, seja bem-vindo ao Hortifruti.");
                Console.WriteLine ("1- Cadastrar produto \n 2- Listar todos os produtos \n 3- Calcular a soma de todos os produtos \n 0- Sair ");

                sair = Console.ReadLine ();

                switch (sair) {

                    case "1":
                        for (int i = 0; i <= 9; i++) {
                            Console.Write ("\nDigite o nome do produto: ");
                            produto[i] = Console.ReadLine ();

                            Console.Write ("Digite o preço: R$");
                            preco[i] = double.Parse (Console.ReadLine ());

                        }
                        break;

                    case "2":
                        for (int i = 0; i <= 9; i++) {
                            if (preco[i] != 0 && produto[i] != "") {
                                Console.WriteLine (produto[i] + " R$" + preco[i]);
                            }
                        }
                        break;

                    case "3":
                        for (int i = 0; i <= 9; i++) {
                            total += preco[i];
                        }
                        Console.WriteLine ("a soma de todos os preços é: R$" + total);
                        break;
                    default:
                        Console.WriteLine ("opção invalida");
                        break;
                }
            }

        }
    }
}