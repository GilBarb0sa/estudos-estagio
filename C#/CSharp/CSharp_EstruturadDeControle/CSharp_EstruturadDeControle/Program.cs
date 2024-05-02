using System;

namespace CSharp_EstruturadDeControle
{
    class Program
    {
        static void Main(string[] args)
        { 
            #region If/Else

            Console.WriteLine("Digite 1 ou 2.");
            var numeroDigitado = Console.ReadLine();

            if (numeroDigitado == "1")
            {
                Console.WriteLine("O número 1 foi digitado.");
            }
            else if (numeroDigitado == "2")
            {
                Console.WriteLine("O número 2 foi digitado.");
            }
            else
            {
                Console.WriteLine("Outro número foi digitado.");
            }

            Console.ReadKey();
            Console.Clear(); // Limpa o console
            #endregion

            #region Switch/Case

            Console.WriteLine("Digite 1 ou 2.");
            numeroDigitado = Console.ReadLine(); // Não declare novamente a variável

            switch (numeroDigitado)
            {
                case "1":
                    Console.WriteLine("O número 1 foi digitado.");
                    break;
                case "2":
                    Console.WriteLine("O número 2 foi digitado.");
                    break; // Adicionei o break aqui
                default:
                    Console.WriteLine("Outro número foi digitado.");
                    break;
            }

            Console.ReadKey();
            Console.Clear(); // Limpa o console
            #endregion

            #region Seleção com Switch-Case

            Console.WriteLine("Seja bem-vindo a empresa X.");

            Console.WriteLine("Digite 1- Contratação de um plano.");
            Console.WriteLine("Digite 2- Reclamação de serviço prestado.");
            Console.WriteLine("Digite 3- Segunda via de boleto.");
            Console.WriteLine("Digite 4- Sair.");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de plano novo.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação.");
                    break;
                case "3":
                    Console.WriteLine("Segunda via de boleto enviada por e-mail.");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada.");
                    break;
            }

            Console.ReadKey();
            Console.Clear(); // Limpa o console
            #endregion

            #region Estrutura de Repetição / For-While-Foreach
            Console.WriteLine("Digite uma sequência de números separados por espaço.");
            // 0 1 2 3 4 5 6 7 8 9 10

            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' '); //para dividir a string em várias substrings com base em um caractere delimitador, que é o espaço 

            Console.WriteLine("Usando For: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
                // 0 1 2 3 4
            }

            Console.WriteLine("Usando While");

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);

                contador++;
            }

            Console.WriteLine("Usando Foreach");  //Muitos mais prático! 

            foreach(var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            Console.Clear(); // Limpa o console
            #endregion
        }
    }
}
