using System;
using System.Collections.Generic;

namespace CSharp_POO
{
    public class Professor : Pessoa // herda da classe Pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "A", "B" };
        }

        public List<string> Turmas { get; private set; } //private limita a modificação somente dentro desta classe
        public decimal Salario { get; private set; }

        public override void SeApresentar() 
        {
            base.SeApresentar();

            var turmas = string.Join(',', Turmas); //permite passar caracteres e coleções

            Console.WriteLine($"Meu salário é {Salario}, e ensino para as turmas {turmas}");
        }
    }
}
