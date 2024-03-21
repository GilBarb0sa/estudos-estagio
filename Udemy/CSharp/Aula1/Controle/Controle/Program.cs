using System;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch - Case
            //int escolha;
            //Console.Write("Escolha um numero de 1 a 4: "); 
            //escolha = int.Parse(Console.ReadLine());

            //switch (escolha)
            //{
            //    default:
            //        Console.WriteLine("Opção Default");
            //        break;
            //    case 1:
            //        Console.WriteLine("Opção 1");
            //        break ;
            //    case 2:
            //        Console.WriteLine("Opção 2");
            //        break ;
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Opção Combinada");
            //        break ;
            //}
            #endregion

            #region
            Inicio:
            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch(op)
            {
                default:
                    goto Inicio;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }

            Console.WriteLine("Valor final " + valor);
            #endregion
            Console.ReadKey();
        }
    }
}
  