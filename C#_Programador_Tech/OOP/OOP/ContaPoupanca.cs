using System;

namespace OOP
{
    public class ContaPoupanca : Conta, IConta //Herda as classes da Conta, tem que ser public
    {
        public ContaPoupanca(int numero, double limite) : base(numero, limite) //O base quer dizer que vamos pegar o construtor da nossa class de herança, Conta
        {
        }

        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("A conta poupança é :" + this.Numero);
        }

        public override bool Saca(double valor)
        {
            bool deuCertoSaque = base.Saca(valor); 

            if(deuCertoSaque)
            {
                this.Saldo -= 6; //Todo saque que for feito na conta poupança, vai realizar o saque cobrando 6 reais
            }
            return false;
        }
    }
}
