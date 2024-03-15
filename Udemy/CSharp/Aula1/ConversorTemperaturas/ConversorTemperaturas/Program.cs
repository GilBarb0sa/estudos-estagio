using System;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### Conversor de Temperaturas ###");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            //(c * 9 / 5) + 32 = F
            f = (c * 9 / 5) + 32;

            //(c + 273,15 = K
            k = (c + 273.15);

            Console.WriteLine(c + " graus celcius = " + f + " graus fahrenheit");
            Console.WriteLine(c + " graus celcius = " + k + " graus kelvin");

            Console.WriteLine("------------------------------------------");
            Console.ReadKey();  

        }
    }
}
