using System;

namespace aula_repeticacao_lacos {
    class Program {
        static void Main (string[] args) {

            // //LAÇO CONTADO - FOR (define a variável contadora e suas condições) - incremento (+)
            for(int cont1 = 1; cont1 <= 100; cont1 ++){

            //Verificamos se os números são diferentes de pares

                if(cont1 % 2 !=0){

                    Console.WriteLine("FOR 0-100 " + cont1);
            }
            }
           
            // //LAÇO CONTADO - FOR - DECREMENTO (-)
            for(int cont2 = 100; cont2 >= 0; cont2 -- ) {

            //Verificamos se os números são diferentes de pares
                 if(cont2 % 2 !=0){

                     Console.WriteLine("FOR 100-0 " + cont2);
            }
            }
            
            //LAÇO CONDICIONAL - WHILE 
            double acumuladora = 0;
            double    nota     = 0;
            int       cont3     = 0;
            string    sair     = "";

            while(sair != "sim"){
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine()); //Console já vem como string, então preciso converter para double;

                acumuladora += nota; //nota += significa que está pegando a própria nota e somando com outro número (ex: contp = contp + 1)
                cont3++; //chamando o próximo número

                Console.Write("Deseja sair da aplicação? sim/não");
                sair = Console.ReadLine().ToLower();
                }

            Console.WriteLine("Média das notas: " + (acumuladora/cont3));

            int cont = 1;
            int acumulador = 0;
            int nota4;

            do { //começa no ponto 0, não preciso declarar nenhuma informação para começar - só declaro no while que é o ponto que eu quero que ele pare
                Console.WriteLine ("Digite a nota do aluno: ");
                nota4 = int.Parse (Console.ReadLine ()); 

                if (nota4 % 3 == 0) { //declarar se o número é múltiplo de 3
                    acumulador = acumulador + nota4;
                }
                cont ++; //chamar o próximo ciclo
            }
            while (cont <= 20); //definir a parada do laço
            Console.WriteLine ("A soma dos números múltiplos de 3 é:" + acumulador);
        }
    }
}