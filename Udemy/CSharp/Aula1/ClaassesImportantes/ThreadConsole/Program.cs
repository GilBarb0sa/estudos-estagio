using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
     class Program
    {
        static void Main(string[] args)  //Thread Principal
        {
            Thread t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;  //Faz com o que quando a Thread principal encerrar o programa finaliza
            t.Start();
            t.Join();  // este metodo da preferencia de execução para a Tarefa

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal"); 
                Thread.Sleep(500); //Coloca os Threads com um intervalo de tempo para ser executado
            }

            //Console.ReadKey();
        }

        static void Tarefa()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada."); 
                Thread.Sleep(1000);
            }
        }
    }
}
