using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_POO
{
    public class Estudante : Pessoa
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento) //ctor tabtab, monta o construtor
            : base(nome, documento, dataNascimento) //chamando o construtor base da Pessoa
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 };
        }

        public string Turma { get; private set; } //Private não quero que fora da minha classe eu permita ser alterado
        public List<int> Notas { get; private set; }

        public override void SeApresentar()  //sobrescreve o metodo apresentar
        {
            base.SeApresentar();

            var media = Notas.Average();

            Console.WriteLine($"Sou um estudante da turma {Turma}, Media de Nota: {media}");
        }

    }
}
