using System;
using System.Security.Cryptography.X509Certificates;

namespace Recursividade
{
     class Program
    {
        static void Main(string[] args)
        {
           Recursiva r = new Recursiva();
           r.ExecutarRecursivo("Ola Mundo!", 3);

           Console.ReadKey();
        }
    }
}
