using System;

namespace TipoDelegate
{
    class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;
            conta += m.Multiplicar;

            conta(10, 2);

            Console.WriteLine();

            conta -= m.Subtrair;
            conta -= m.Dividir;

            conta(15, 3);

            Console.ReadKey();
        }
    }
}
