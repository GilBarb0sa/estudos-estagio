using System;

namespace Estaticas
{
     partial class Pessoa
    {
        public void Apresentar()
        {
            Console.WriteLine("Ola eu sou " + nome);
        }

        public static int Calcularidade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
