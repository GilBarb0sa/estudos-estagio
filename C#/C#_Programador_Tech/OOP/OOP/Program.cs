using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo OOP!");

            AnalistaTI analistaTI = new AnalistaTI();

            analistaTI.AdicionarNome("Acaciano", "Neves");
            analistaTI.AdicionarSalarioPadrao(1000);

            analistaTI.Reajustar();

            Console.WriteLine("Salário é : " + analistaTI.Salario);










            //ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Saca(10);
            //double saltoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();

            //Console.WriteLine("Saldo Poupança é: " + saltoPoupanca);


            //ContaCorrente contaCorrente = new ContaCorrente(111, 100);

            //contaCorrente.Deposita(100);
            //contaCorrente.Saca(10);
            //double saltoCorrente = contaCorrente.ConsultaSaldoDisponivel();

            //Console.WriteLine("Saldo Corrente é: " + saltoCorrente);







            //AnalistaTI analistaTI = new AnalistaTI();
            //Gerente gerente = new Gerente();
            //GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            //GerenteTI gerenteTI = new GerenteTI();

            //analistaTI.Nome = "Acaciano Neves";
            //analistaTI.Salario = 3000;

            //Console.WriteLine("Salario do Analista de TI é: " + analistaTI.Salario);

            //analistaTI.Reajustar();

            //Console.WriteLine("Salario do Analista de TI reajustado é: " + analistaTI.Salario);

            //Console.WriteLine("________________________________________________________________________");

            //gerente.Nome = "Amanda Neves";
            //gerente.Salario = 8000;

            //Console.WriteLine("Salario do Gerente é: " + gerente.Salario);

            //gerente.Reajustar();

            //Console.WriteLine("Salario do Gerente reajustado é: " + gerente.Salario);

            //Console.WriteLine("________________________________________________________________________");


            //gerenteDeAgencia.Nome = "Freire Neves";
            //gerenteDeAgencia.Salario = 10000;

            //Console.WriteLine("Salario do Gerente é: " + gerenteDeAgencia.Salario);

            //gerenteDeAgencia.Reajustar();

            //Console.WriteLine("Salario do Gerente reajustado é: " + gerenteDeAgencia.Salario);

            //Console.WriteLine("________________________________________________________________________");

            //gerenteTI.Nome = "Ronaldo Neves";
            //gerenteTI.Salario = 20000;

            //Console.WriteLine("Salario do Gerente é: " + gerenteTI.Salario);

            //gerenteTI.Reajustar();

            //Console.WriteLine("Salario do Gerente reajustado é: " + gerenteTI.Salario);

            //Console.WriteLine("________________________________________________________________________");





            /*ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0); //instanciando

            contaPoupanca.Deposita(100);
            contaPoupanca.Saca(10);

            double saldo = contaPoupanca.ConsultaSaldoDisponivel();

            contaPoupanca.MostrarNumeroDaConta();

            Console.WriteLine("Saldo da conta poupança é: " + saldo);

            Conta conta = new Conta(113, 100);

            conta.Deposita(500);
            conta.Saca(140);

            double saldoContaCorrente = conta.ConsultaSaldoDisponivel();
            Console.WriteLine("Saldo da conta corrente é: " + saldoContaCorrente);
            */


            /*Conta conta1 = new Conta(123, 500);
            Conta conta2 = new Conta(563, 100);
            Conta conta3 = new Conta(321, 900);

            Console.WriteLine("Total de contas: " + Conta.TotalContasCriadas);

            int total = Conta.ProximoTotalContasCriadas();

            Console.WriteLine("Total de contas: " + total);
            */

            //Criando  um objeto de cada classe

            /*CartaoDeCredito cdc = new CartaoDeCredito(); // instanciando
            Cliente c = new Cliente();

            //Adicionando o nome do cliente
            c.Nome = "Acaciano Neves";

            //Adicionando o numero e data de validade do cartão
            cdc.Numero = "5249754457145953";
            cdc.DataDeValidade = "02/2025";

            cdc.Cliente = c;

            Console.WriteLine("O nome do Cliente é: " + c.Nome);
            Console.WriteLine("O numero do cartão é :" + cdc.Numero);
            Console.WriteLine("A data de validade do cartão é :" + cdc.DataDeValidade);
            Console.WriteLine("O nome do Cliente é: " + cdc.Cliente.Nome); // esta linha funciona devido ao agregamento feito no cartão de crédito
            */


            /*Conta conta = new Conta(123, 300); // Para criar um objeto, você precisa criar uma instância da class Conta por exemplo

            conta.AdicionarLimite(1500);

            conta.Deposita(1500);
            conta.Deposita(10);
            conta.Deposita(100);
            conta.Deposita(500);

            bool saca = conta.Saca(600);

            if(saca)
            {
            double saldo = conta.ConsultaSaldoDisponivel();

            Console.WriteLine("Seu saldo é: " + saldo);
            Console.WriteLine("Seu limite é: " + conta.Limite);
            Console.WriteLine("O numero da sua conta é: " + conta.Numero);
            }*/
        }
    }
}
