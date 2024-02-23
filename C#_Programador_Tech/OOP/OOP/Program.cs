using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo OOP!");

            Conta conta1 = new Conta(); // Para criar um objeto, você precisa criar uma instância da class Conta

            Conta conta2 = new Conta(); // Nova instância

            //Atribuindo os valores para conta 1
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            //Atribuindo os valores para conta 2
            conta2.Saldo = 2000;
            conta2.Limite = 600;
            conta2.Numero = 1456;

            Console.WriteLine("Olá, fulano, seu saldo em conta é: " + conta1.Saldo );
            Console.WriteLine("Limite de saque: " + conta1.Limite);
            Console.WriteLine("O numero da conta é: " + conta1.Numero);

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Olá, fulano, seu saldo em conta é: " + conta2.Saldo);
            Console.WriteLine("Limite de saque: " + conta2.Limite);
            Console.WriteLine("O numero da conta é: " + conta2.Numero);


        }
    }
}
