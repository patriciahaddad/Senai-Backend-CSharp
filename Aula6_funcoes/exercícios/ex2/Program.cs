using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiaSemana();
        }
        /// <summary>
        /// Dia da semana
        /// </summary>
          static void DiaSemana(){
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }
    }
}
