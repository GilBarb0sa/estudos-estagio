using System;
using System.Collections.Generic;

namespace CSharp_POO
{
    public class Professor : Pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "A", "B" };
        }

        public List<string> Turmas { get; private set; }
        public decimal Salario { get; private set; }
    }
}
