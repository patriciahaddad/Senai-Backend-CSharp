using System;

namespace ex5
{
    class Program
    {
        static void Main(string [] args)
        {
            int[] dobro = new int [10];

            for(int i = 0; i <= 9; i++) { //definir o tamanho do vetor (sempre começa com 0)
                dobro[i] = (i*2);
            }
            for (int i=0; i<=9; i++){
                Console.WriteLine(dobro[i]);
            }
    }
}
}