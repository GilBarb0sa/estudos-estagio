﻿namespace SistemaCadastro
{
     class Pessoa
    {
        internal static Pessoa p;

        public string Nome { get; set; } //propriedades
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropria {  get; set; }
        public bool Veiculo { get; set; }
        public char Sexo {  get; set; }
    }
}
