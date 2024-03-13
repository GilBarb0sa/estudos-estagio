using System;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 100; // 8bits, de 0 a 255
            ushort nume2; // 16bits, de 0 a 65.535

            float num3 = 1250.45f;
            double num4 = num3;

            num3 = num1;
            nume2 = num1;

            int numero = 'C';

            Console.WriteLine(numero);
            Console.ReadKey();
        }
    }
}
