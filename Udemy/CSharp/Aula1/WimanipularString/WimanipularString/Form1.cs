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

        string nome = "Gilberto";
        string nomeMaiusculo = nome.ToUpper();
        string nomeMinusculo = nome.ToLower();
        //label1.Text = nomeMaiusculo;
        label1.Text = nomeMinusculo;

        #endregion
        }
    }
}
