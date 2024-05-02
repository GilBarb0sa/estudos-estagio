using System;

namespace MediaGeralPOO
{
    class Aluno
    {
        public string Nome {  get; private set; } // O nome de aluno não é possivel alterar, pois o set esta private
        private double[] _notas;  //Os [] sinaliza que este objeto é uma array
        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas) // construtor, inicia sempre com o nome da classe
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i ++)
            {
                Console.Write("Notas #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i ++)
            {
                total += _notas[i];
            }

            return total / _notas.Length;
        }
    }
}
