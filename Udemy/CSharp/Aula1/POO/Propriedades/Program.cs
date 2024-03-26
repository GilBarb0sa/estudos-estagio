using System;

namespace Propriedades
{
     class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Gilberto";
            t.Idade = 12;
           

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);

            Console.ReadKey();
        }
    }
}
