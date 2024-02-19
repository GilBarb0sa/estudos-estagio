using System;

namespace CsharpDiretoAoPontoHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados
            
            int numeroInt = 10;

            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 1231232132312131;

            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue; // 

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Gilberto Dev";
            char letra = 'L';

            DateTime entradaEmpresa = new DateTime(2011, 1, 1);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;

            #endregion

            #region Conversões

            int notaAluno = 10;

            // Conversão Implícita
            double notaAlunoDouble = notaAluno;

            // Conversão Explícita
            int numeroDoubleComoInt = (int)notaAlunoDouble;

            // Convert utilizando Convert
            string notaString = "10";
            int notaConvert = Convert.ToInt32(notaString); // concerte uma string em un número inteiro

            // Conversão utilizando Parse
            int notaParse = int.Parse(notaString);

            if (int.TryParse(notaString, out int notaParse)) // Melhor opção pois se tiver algum erro como caractere no número, ele dará um erro
            {
                // Use a variável 'notaParse' conforme necessário
            }
            else
            {
                Console.WriteLine("Número em formato inválido.");
            }

            #endregion

            #region Operadores Aritméticos

            //Unários  ++, --, + e -

            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++); // 4
            Console.WriteLine(numeroOperador--); // 5

            Console.WriteLine(++numeroOperador); // 5 O sinal na frente ele já entrega o valor crementado ou decrementado
            Console.WriteLine(--numeroOperador); // 4

            Console.WriteLine(numeroOperador); // 4
            Console.WriteLine(-numeroOperador); // -4
            Console.WriteLine(-(-numeroOperador)); // 4  "- com - da +"

            // Binários * / + -

            #endregion

            #region Operadores de Comparação > >= < <=

            Console.WriteLine(4 > 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 5);

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);

            #endregion

            #region Operadores de Igualdade ==, !=

            Console.WriteLine(5 == 5);
            Console.WriteLine(5 == 4);

            Console.WriteLine(5 != 5);
            Console.WriteLine(4 != 5);

            #endregion


            #region Operadores Lógicos AND && e OR ||

            var minhaNota = 7;
            var ultimoAno = true;

            if (minhaNota >= 7 && ultimoAno == true)
            {
                Console.WriteLine("Aprovado e terminou o curso, parabéns!");
            }

            if (minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado!");
            }


            Console.WriteLine(true || false); //true
            Console.WriteLine(false || true); //true
            Console.WriteLine(true || true); //true
            Console.WriteLine(false || false); //false

            Console.WriteLine(true && false); //false
            Console.WriteLine(false && true); //false
            Console.WriteLine(true && true); //true
            Console.WriteLine(false && false); //false

            #endregion

            Console.Read();
        }
    }
}