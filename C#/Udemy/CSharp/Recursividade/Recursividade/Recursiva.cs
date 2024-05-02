using System;

namespace Recursividade
{
    class Recursiva
    {

        //Metodo não recursivo
        public void Executar(string mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        //Metodo recursivo
        public void ExecutarRecursivo(string mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, n-1);
            }
        }
    }
}
