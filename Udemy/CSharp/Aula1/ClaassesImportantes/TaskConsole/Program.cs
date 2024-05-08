using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task Parte 1
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa);  // Não há necessidade de iniciar o Start

            //Task.Run(Tarefa);  //Não há necessidade de criar objetos

            //Task.Factory.StartNew(Tarefa);  //Cria um task já com um retorno do que foi passado

            //Task.Run(() =>                  // Passa uma tarefa anonima, sem a necessidade de um metodo!
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa do anonima.");
            //    }
            //});

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Principal.");
            //}
            #endregion

            #region Task Parte 2
            //Task[] tasks =   //Array de Tasks
            //{
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #1");
            //    }),

            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #2");
            //    }),

            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa #3");
            //    })
            //};

            //Task.WaitAll(tasks);  // Faz com o que A Task execute primeiro as tasks e depois o Principal

            //Task t1 = Task.Run(() => { Console.WriteLine("Comando #1"); });
            //Task t2 = Task.Run(() => { Console.WriteLine("Comando #2"); });
            //Task t3 = Task.Run(() => { Console.WriteLine("Comando #3"); });

            //Task.WaitAll(t1,t2,t3);

            //Console.WriteLine("Principal");
            #endregion

            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(5));
            //Console.WriteLine(tarefa1.Result);

            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);  // Gera numero aleatorio para o retorno até 10
            });

            Task<int> tarefa2 = tarefa1.ContinueWith((num) =>  //retorna o dobro da tarefa 1
            {
                return num.Result * 2;
            });

            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>  //O ContinueWith faz com o que a task aguarde a anterior para dar continuidade
            {
                return "Valor Final " + num.Result;
            });

            Console.WriteLine(tarefa3.Result);

            Console.ReadKey ();
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static private void Tarefa() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do Task.");
            }
        }   
    }
}
