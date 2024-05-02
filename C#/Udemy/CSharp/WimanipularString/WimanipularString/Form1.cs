using System;
using System.Windows.Forms;

namespace WimanipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variável é alfanumerica.";

            //if (texto.Contains("tipo de var"))
            //{
            //    label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não Contém.";
            //}

            //int num = 2024;
            //bool res = true;
            //label1.Text = res.ToString();
            #endregion

            #region ToUpper / ToLower

            //string nome = "Gilberto";
            //string nomeMaiusculo = nome.ToUpper();
            //string nomeMinusculo = nome.ToLower();
            ////label1.Text = nomeMaiusculo;
            //label1.Text = nomeMinusculo;

            #endregion

            #region IndexOf / LastIndexOf

            //string nome = "Gilberto Barbosa";
            ////int indice = nome.IndexOf('a',3, 12); //Procura a primeira letra que aparecer e quero pegar em nome, a partir do indice 3 até o 15
            //int indice = nome.LastIndexOf('a'); //Procura o indice da ultima letra desta string
            //label1.Text = "Indice: " + indice;

            #endregion

            #region Insert / Replace

            //string nome = "Gilberto da Silva Filho";
            ////string nomeFinal = nome.Insert(8, " Barbosa"); //Insiro o indice que será inserido a nova string
            //string nomeFinal = nome.Replace("Gilberto", "Saskaroth"); //Substitui um char ou string por uma nova

            //label1.Text = nomeFinal;

            #endregion

            #region Length / Substring

            //string nome = "Gilberto Barbosa";
            ////int tam = nome.Length;
            ////label1.Text = "O nome " + nome + " contém " + tam + " letras";

            ////for (int i = 0; i <nome.Length; i++) //Apresenta o nome conforme seu comprimento
            ////{
            ////    label1.Text += nome[i] + "\n";
            ////}

            //string parte = nome.Substring(nome.IndexOf(" ")); //Aprensenta em tela a string a partir do espaço " " que foi declara.
            //label1.Text = parte;

            #endregion

            #region Split

            //string nomes = "Gilberto,Islaine,Juliana,Matheus,Bruno,Rafael,Marineuza";
            //char[] separador = { ',' };  //Cria uma array  de caractere que será utilizado para separar as strings
            //string[] resultado = nomes.Split(separador); //Cria uma array onde existe o separador de strings

            //foreach (string nome in resultado) //Inseri o resultado numa lista de nome, pulando uma linha
            //{
            //    label1.Text += nome + "\n";
            //}

            #endregion

            #region StartWith / EndsWith

            //string nome = "Gilberto";
            //// bool res = nome.StartsWith("gil", StringComparison.OrdinalIgnoreCase); //Ignora o case sensitive do c#
            //bool res = nome.EndsWith("RTO", StringComparison.OrdinalIgnoreCase);
            //if (res)
            //{
            //    label1.Text = "Positivo";
            //} 
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            #endregion

            #region Trim / TrimStart / TrimEnd

            //string mensagem = "   ----___   000 Ola Gilberto ----   ";
            //char[] c = { ' ', '-', '_', '0' };  //Array de caracteres que serão retirado ao imprimir no label1
            //string nova = mensagem.Trim(c); // TrimStart ele elimina os caracteres do começo e o TrimEnd o do final

            //label1.Text = ">"  + nova + "<";

            #endregion

            #region Compareto / Equals

            //string nome = "Gilberto";
            //string nome2 = "gilberto";

            //if(nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))    //Compara as strings
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString();   //Classifica a ordem alfabetica das strings

            #endregion

            #region

            decimal valor = 19.95m;
            int temp = 32;
            //string s = String.Format("O valor do produto é {0:C2} e a temperatura é {1}", valor, temp);

            //string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now); //Entrega a data e a hora, podendo ser mais simples, colocando o d ou t minusculo.

            //string s = $"O valor do produto é {valor:C2} e a temperatura é {temp}";

            string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";

            label1.Text = s;

            #endregion
        }
    }
}
