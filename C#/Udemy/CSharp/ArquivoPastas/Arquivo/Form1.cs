using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = @"c:\curso\";
            string arquivo = "teste.txt";

            //bool res = File.Exists(pasta + arquivo);  //Verifica se existe o arquivo
            //label1.Text = res.ToString();


            //File.Delete(pasta + arquivo);  //Deleta o arquivo


            //if (!File.Exists(pasta + arquivo))  //Condição para não sobrescrever o arquivo já existente
            //{ 
            //    File.Create(pasta + arquivo).Close();  //Cria o arquivo e fecha o programa para não ter erro ao tentar criar novamente
            //    label1.Text = "Criado!";
            //}
            //else
            //{
            //    label1.Text = "Já existe!";
            //}


            //if (File.Exists(pasta + arquivo))
            //{
            //    File.Copy(pasta + arquivo, pasta + "Copia.txt", true);  // True permite a sobrescrita
            //    label1.Text = "Copiado!";
            //}
            //else
            //{
            //    label1.Text = "Arquivo não existe!";
            //}


            //File.Move(pasta + arquivo, pasta + "destino\\" + arquivo);  //Movimenta o arquivo de pasta


            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo novo", Encoding.Default);  //Se o arquivo existir ele sobrescreve aquele arquivo
   
            //label1.Text = File.ReadAllText(pasta + arquivo, Encoding.Default);  //Realiza uma leitura do texto que foi inserido acima

            //label1.Text = File.GetCreationTime(pasta + arquivo).ToString();  //Ele traz no formato datetime a data de criação do arquivo

            File.SetCreationTime(pasta + arquivo, DateTime.Now);  //altera a data de criação do arquivo
        }
    }
}

    //File.Exists()
    //Existe.Delete()
    //File.Create()
    //File.Move()
    //File.Copy()
    //File.WriteAllText()
    //File.ReadAllText()
