using System;

namespace TipoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            //int[] numeros = new int[5];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //numeros[2] = 55;

            //string[] nomes =
            //{
            //    "Gil",
            //    "Islaine",
            //    "Juliana",
            //    "Matheus"
            //};

            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(nomes[0]);
            #endregion

            #region Matriz
            //int[,] numeros = new int[2, 3];

            //numeros[0, 0] = 10;
            //numeros[0, 1] = 20;
            //numeros[0, 2] = 30;

            //numeros[1, 0] = 40;
            //numeros[1, 1] = 50;
            //numeros[1, 2] = 60;

            //Console.Write("[" + numeros[0, 0]+ "]");
            //Console.Write("[" + numeros[0, 1] + "]");
            //Console.Write("[" + numeros[0, 2] + "]");

            //Console.WriteLine();

            //Console.Write("[" + numeros[1, 0] + "]");
            //Console.Write("[" + numeros[1, 1] + "]");
            //Console.Write("[" + numeros[1, 2] + "]");

            //Console.WriteLine();

            //string[,] nomes =
            //{
            //    {"Gil","Islaine", "Juliana","Matheus" },
            //    {"Marineuza", "Gilberto", "Rose", "Gamora" }
            //};

            //Console.WriteLine(nomes[0,1]);
            #endregion

            #region Multiplicação de Matrizes
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultado = new int[2, 2];


            Console.WriteLine("Preencher a matriz #1");

            for(int linha = 0; linha < 2; linha++) 
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("Preencher a matriz #2");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2. Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado de matriz #1 x matriz #2");
            resultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0, 0] + "][" + resultado[0, 1] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "][" + resultado[1, 1] + "]");
            #endregion
            Console.ReadKey();
        }
    }
}
