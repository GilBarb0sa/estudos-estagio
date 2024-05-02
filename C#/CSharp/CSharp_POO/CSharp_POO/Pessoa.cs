using System;

namespace CSharp_POO
{
    public abstract class Pessoa //Abstract a classe não vai ser instancia por si só e sim herdada de outras
    {
        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;
        }

        //Propriedades
        public string Nome { get; protected set; } // protected previne de alterações fora da classe filha
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; set; }

        public virtual void SeApresentar()  //Imprimi na tela e Sobrescreve
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Documento {Documento}, Data de Nascimento: {DataNascimento}");
        }
    }
}
