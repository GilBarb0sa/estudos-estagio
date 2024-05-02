using System;

namespace CSharp_TrabalhandoComStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Principais Métodos, Campo e Propriedade

            var paragrafo = "   C# é uma linguagem moderna   e versátil." + 
                "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                "Mobile, entre outros. ";

            // Length
            var tamanho = paragrafo.Length; //da o complimento do paragrafos

            // Empty
            var vazio = string.Empty; //cria uma variável chamada vazio e a inicializa com uma string vazia.

            // ToLower, ToUpper
            var paragrafoMinusculo = paragrafo.ToLower(); //Deixa o paragrafo minusculo
            var paragrafpMaiusculo = paragrafo.ToUpper(); //Deixa o paragrafo maiusculo

            // Split
            var frase = paragrafo.Split('.'); // identifica todos os paragrafos que finaliza com "."

            // Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim(); //Remove os espaços do inicio e final do paragrafos.
            var paragrafoTrimEnd = paragrafo.TrimEnd(); //Remove o espaço final do paragrafo
            var paragrafoTrimStart = paragrafo.TrimStart(); //Remove o espaço de inicio do paragrafo

            // IsNullOrWhitespace
            var isNullOrWhitescpace = string.IsNullOrWhiteSpace(paragrafo); //verifica se o valor é nulo ou vazio retornando true ou false

            //Replace
            var paragrafoCSharp = paragrafo.Replace("#", "-sharp"); //seleciona a sting que será substituido

            #endregion

            #region Busca

            var outroParagrafo = "C# é uma linguagem moderna e versátil." +
                "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                "Mobile, entre outros.";

            // IndexOf
            var indexOf = outroParagrafo.IndexOf("C#"); //Encontra a primeira ocorrência da string selecionada

            // LastIndexOf
            var lastIndexOf = outroParagrafo.LastIndexOf("C#"); //Encontra a ultima ocorrência da string selecionada

            // StartWith
            var startWith = outroParagrafo.StartsWith("C#"); //verefica se começa com a string indicada

            // Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile"); //busca o mobile no paragrafo
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6); //retorna o pedaço da string e o tamanho

            // Contains
            var containsJogos = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase); //verifica se existe a string jogos
            var containsjogos = outroParagrafo.Contains("jogos"); // // verifica se existe a string selecionada, igual! Aqui da False
            var containsJogosExact = outroParagrafo.Contains("Jogos"); // verifica se existe a string selecionada, igual!
            var containsRuim = outroParagrafo.Contains("ruim"); 

            #endregion

            Console.ReadKey();
        }
    }
}
