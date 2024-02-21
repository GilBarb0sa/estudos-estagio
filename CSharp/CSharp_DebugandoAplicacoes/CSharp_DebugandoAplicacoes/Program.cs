using System;

namespace CSharp_DebugandoAplicacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Debugging

            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' '); // Se estiver errada, você pode testar mudar o valor e avançar com código
            // o split transforma os número em arrays ou matrizes de números com espaços entre elas

            foreach (var numero in numeros) //laço de repetição
            {
                var numeroInt = int.Parse(numero); // conerte um a um em inteiro

                var aoQuadrado = Math.Pow(numeroInt, 2);

                Console.WriteLine($"{numeroInt}² = {aoQuadrado}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
