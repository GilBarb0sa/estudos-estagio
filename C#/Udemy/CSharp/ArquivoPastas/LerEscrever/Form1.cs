using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscrevertxt_Click(object sender, EventArgs e)
        {
            string path = @"c:\curso\teste\file.txt";
            StreamWriter writer = new StreamWriter(path, true, Encoding.Default);  // O true faz com que adiciona conteudo de txt e não sobrescreva

            //string linha = txtConteudo.Text;
            //writer.WriteLine(linha);

            string txt = txtConteudo.Text;
            writer.Write(txt);

            //writer.Flush();  //Libera os recursos do Stream
            //writer.Dispose();  //Libera mais recursos
            writer.Close();  //Fecha

            txtConteudo.Clear();
        }

        private void btnLerTxt_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();

            string path = @"c:\curso\teste\file.txt";
            StreamReader reader = new StreamReader(path, Encoding.Default);

            //string txt = reader.ReadToEnd();  //Lê o texto inteiro

            //string linha = reader.ReadLine(); //Lê apenas uma linha           

            //string linha = reader.ReadLine();

            //while (linha != null)  //linha diferente de null, então quer dizer que leu a linha
            //{
            //    txtConteudo.Text += linha + "\n";
            //    linha = reader.ReadLine();
            //}

            while (!reader.EndOfStream)  //Enquanto não chegar no final do arquivo faça o seguinte
            {
                txtConteudo.Text += (char)reader.Read() +" ";  //char é utilizado para converter 
            }

            reader.Close();
        }

        private void btnLerBinary_Click(object sender, EventArgs e)
        {
            string path = @"c:\curso\teste\Arquivo.txt";
            FileStream file = File.OpenRead(path);
            BinaryReader reader = new BinaryReader(file);  //retorna os bytes do arquivo

            //while (reader.BaseStream.Position != reader.BaseStream.Length)  //Retorna a posição atual e verifica se esta posição é diferente do tamanho do arquivo
            //{
            //    byte b = reader.ReadByte();

            //    txtConteudo.Text += (char)b;  //pega o byte e converte em char para leitura
            //}

            buffer = reader.ReadBytes((int)reader.BaseStream.Length);  //Retorna um array com todos os bytes

            foreach (byte b in buffer)
            {
                txtConteudo.Text += (char)b;
            }

            reader.Close();
            //buffer = File.ReadAllBytes(path);  //retorna um array de todos os bytes
        }

        private void btnEscreverBinary_Click(object sender, EventArgs e)
        {
         
            string path = @"c:\curso\teste\ArquivoNovo.txt";
            FileStream file = File.OpenWrite(path);
            BinaryWriter writer = new BinaryWriter(file);

            writer.Write(buffer);

            writer.Close();
        }
    }
}
