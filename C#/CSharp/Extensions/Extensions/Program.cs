using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;

            Console.WriteLine(numero.EhMaior(10));

            Console.WriteLine(numero.MultiplicaPor100());

            var conta = new Conta();
            conta.PagarConta();
            conta.PagarContaComCartao();

            Console.ReadKey();

        }
    }
}
