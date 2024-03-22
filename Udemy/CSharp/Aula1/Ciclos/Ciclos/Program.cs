using System;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo While
            //int valor = 0;
            //while (valor <= 10) 
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}
            #endregion

            #region Do-WHile
            //int valor = 1;
            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //} while (valor <= 10);
            #endregion

            #region Ciclo For
            //for (int i = 0, j =9; i < 10; i++, j--) 
            //{
            //    Console.WriteLine("I = " + i + "  |  " + "J = "+ j);
            //}
            #endregion

            #region Ciclo Foreach
            string[] nomes = { "Gil", "Islaine", "Marienuza", "Gilberto", "Juliana", "Matheus" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: "+ nome);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
