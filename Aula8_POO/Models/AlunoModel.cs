namespace Aula8_POO.Models
{
    public class AlunoModel
    {
        /// <summary>
        /// Nome do Aluno
        /// </summary>
        /// <value>string</value>
        public string Nome {get; set;}

        /// <summary>
        /// Nome do curso
        /// </summary>
        /// <value>string</value>
        public string Curso {get; set;}

        /// <summary>
        /// Número do RA do aluno
        /// </summary>
        /// <value>string</value>
        public string RA {get; set;}

        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int Idade {get; set;}

        
        /// <summary>
        /// Começa a estudar
        /// </summary>
        public void Estudar()
        {
            System.Console.WriteLine("Estou estudando!");
        }

        /// <summary>
        /// Pede café para o professor
        /// </summary>
        public void PedirIntervalo()
        {
            System.Console.WriteLine("Pode fazer intervalo?");
            System.Console.WriteLine("QUERO CAFÉ!");
        }

        /// <summary>
        /// Pede ajuda
        /// </summary>
        public void PedirAjuda()
        {
            System.Console.WriteLine("Ô Paulo, chega ae!");
        }

    }
}