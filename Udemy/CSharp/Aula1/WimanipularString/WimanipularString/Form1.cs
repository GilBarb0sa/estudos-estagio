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

            #region

            string nome = "Gilberto Barbosa";
            //int tam = nome.Length;
            //label1.Text = "O nome " + nome + " contém " + tam + " letras";

            //for (int i = 0; i <nome.Length; i++) //Apresenta o nome conforme seu comprimento
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            string parte = nome.Substring(nome.IndexOf(" ")); //Aprensenta em tela a string a partir do espaço " " que foi declara.
            label1.Text = parte;

            #endregion
        }
    }
}
