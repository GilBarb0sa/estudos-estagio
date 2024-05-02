using System;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //byte num1 = 100; // 8bits, de 0 a 255
            //ushort nume2; // 16bits, de 0 a 65.535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;
            //nume2 = num1;

            //int numero = 'C';
            #endregion

            #region Conversão Explícita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            //char letra = (char)97;

            #endregion

            #region Método Parse

            //string txtNumero = "1917";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");

            //float num3 = float.Parse("457,75");

            #endregion

            #region Class Convert

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');

            #endregion

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
