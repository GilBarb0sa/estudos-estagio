using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Funcionario
    {
        private string Nome { get; set; }
        public double Salario { get; protected set; } // o protected deixa que o salario possa ser lido mas não manipulado

        public abstract void Reajustar(); //Metodo abstrato, pois ele será um modelo

        public void AdicionarNome(string primeiroNome, string sobreNome)
        {
            string nomeCompleto = primeiroNome + " " + sobreNome;
            this.Nome = nomeCompleto;
        }

        public void AdicionarSalarioPadrao(double salario)
        {
            this.Salario = salario;
        }
    }
}
