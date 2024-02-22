using System;
using System.Collections.Generic;

namespace CSharp_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
            var estudante = new Estudante("A", "Luis", "54321", new DateTime(1992, 1, 1));

            var pessoas = new List<Pessoa> { estudante, professor }; //Inicia uma lista de pessoas

            foreach (var pessoa in pessoas)
            {
                pessoa.SeApresentar();
            }

            Console.Read();
        }
    }
}
