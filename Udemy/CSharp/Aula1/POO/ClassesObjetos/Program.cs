using System;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Gilberto";
            p1.sobrenome = "Barbosa";
            p1.anoNascimento = 1991;

            Pessoa p2 = new Pessoa()
            {
                nome = "Islaine",
                sobrenome = "Amir",
                anoNascimento = 1995
            };

            p1.nome = "Gil";

           Console.WriteLine("Pessoa 1: " + p1.nome );
           Console.WriteLine("Pessoa 1: " + p1.sobrenome);
           Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
           p1.Cumprimentar();

           Console.WriteLine("");

           Console.WriteLine("Pessoa 2: " + p2.nome);
           Console.WriteLine("Pessoa 2: " + p2.sobrenome);
           Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
           p2.Cumprimentar();

           Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
