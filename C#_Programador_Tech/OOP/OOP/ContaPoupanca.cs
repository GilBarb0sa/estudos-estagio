using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaPoupanca : Conta //Herda as classes da Conta, tem que ser public
    {
        public ContaPoupanca(int numero, double limite) : base(numero, limite) //O base quer dizer que vamos pegar o construtor da nossa class de herança, Conta
        {
        }

        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("A conta poupança é :" + this.Numero);
        }
    }
}
