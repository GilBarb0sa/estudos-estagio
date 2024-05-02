using System;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);
            
            if (valorIMC < 20) 
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Abaixo do peso.");
            }
            else if ((valorIMC >= 20) && (valorIMC < 25))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Peso normal.");
            }
            else if ((valorIMC >= 25) && (valorIMC < 30))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Obeso.");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> Muito Obeso.");
            }


            Console.ReadKey();
        }
    }
}
