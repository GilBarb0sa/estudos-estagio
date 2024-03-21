using System;

namespace Condicao
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region COndição Simples If-Else
            //int valor = 5;

            //if(valor > 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condição retornou falso");
            //}
            #endregion

            #region Condições Encadeadas If-Else If- Else
            //int valor;
            //Console.WriteLine("Digite um valor: ");
            //valor = int.Parse(Console.ReadLine());

            //if(valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if( valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição alternativa 1");
            //}
            //else if(valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}
            #endregion

            #region Condição aninhadas
            //int numero;
            //Console.Write("Digite um número: ");
            //numero = int.Parse(Console.ReadLine());

            //if (numero > 5) 
            //{
            //    Console.Write("O número é maior que 5");
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e também é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" mas não é par.");
            //    }
            //}
            #endregion

            #region Operador Ternario 
            //int numero;
            //numero = int.Parse(Console.ReadLine());
            //string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";    #Terceiro Metodo

            ////condição ? true : false;

            //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";    #Segundo Metodo

            //if (numero > 5)        #Primeiro Metodo
            //{
            //    mensagem = "Maior que 5";
            //}
            //else
            //{
            //    mensagem = "Menor que 5";
            //}

            //Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5"); #Quarto e melhor Metodo!

            #endregion

            Console.ReadKey();
        }
    }
