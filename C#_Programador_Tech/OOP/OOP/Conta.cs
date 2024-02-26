using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Conta : IConta
    { 
        public Conta(int numero, double limite) //O construtor tem que ter sempre o nome da class
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalContasCriadas++; //Vai pegar o valor que tem dentro dela que começa com 0 e adicionando sempre + 1 !Esta estatico!
        }

        //Protected : Ele é protegido. Toda classe tem acesso e tbm as classes na herança, dos atributos e metodos protegidos.
        //Private : Somente a classe tem o poder de alterar o valor dele 
        //Get : Diz que pode ser acessado, pode ser buscado 
        //Set : Pode adicionar um valor para este saldo
        protected double Saldo { get; set; }  // Toda classe tem acesso e tbm as classes na herança, dos atributos e metodos protegidos.
        public double Limite { get; private set; }
        public int Numero { get; private set; }
        public static int TotalContasCriadas { get; set; } // deixa ele como estaticona classe

        //Metodos - Vai ser as ações dentro das classes
        public static int ProximoTotalContasCriadas() //metodo estatico
        {
            return Conta.TotalContasCriadas + 1;
        }

        public void Deposita(double valor) //void diz que não vai retornar nada
        {
            this.Saldo += valor; //+= incrementa o valor que esta vindo do metodo, acrescenta o valor no Saldo
        }

        public virtual bool Saca(double valor) //bool : true or false Se deu certo ou não a realização do saque neste metodo / Virtual - Permite qualquer classe que herda dele, pode ser sobrscrito!
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel(); 
            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponivel");
                return false;
            }

            this.Saldo -= valor; // -= subtrai o valor do Saldo
            return true;
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor; // Esta com apenas o = somente para informar o valor no Limite
        }

        public double ConsultaSaldoDisponivel() //double já retorna valor
        {
            return this.Saldo + this.Limite; //retorna uma Consulta com saldo e limite
        }
    }
}
