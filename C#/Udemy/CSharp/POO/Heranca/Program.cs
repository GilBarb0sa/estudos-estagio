using System;

namespace Heranca
{
     class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();

            //c.Parar();
            //b.Parar();
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("\nHumano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem");
            c.Olhos();
            c.Cabelos();




            Console.ReadKey();
        }
    }
}
