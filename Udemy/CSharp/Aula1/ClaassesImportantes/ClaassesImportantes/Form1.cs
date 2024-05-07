using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {           
            //MessageBox.Show("Ola Mundo!");

            //MessageBox.Show("Mensagem a se impresa", "Titulo da mensagem");

            //DialogResult res = MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.OKCancel);
            //if (res == DialogResult.OK)
            //{
            //    lblResultado.Text = "Clicou em Ok";
            //}
            //else if (res == DialogResult.Cancel)
            //{
            //    lblResultado.Text = "Clicou em Cancelar";
            //}

            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int valor = r.Next(100);  //Gera numeros aleatorios de 0 - 99
            double valor2 = r.NextDouble() * 100;

            lblResultado.Text = "Número: " + valor2.ToString();
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = TimeSpan.FromTicks(1000000000).ToString();

            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio = new TimeSpan(1, 0, 0);

            TimeSpan fim = new TimeSpan(3, 30, 0);

            //TimeSpan intervalo = fim - inicio;

            TimeSpan intervalo = fim.Subtract(inicio); // Aqui esta sendo feito um exemplo de um horario sendo subtraido com o uso de TimeSpan

            lblResultado.Text = intervalo.ToString();

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2023, 2).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2024).ToString(); // retorna um booleano informando se o ano é bissexto ou não
            //lblResultado.Text = DateTime.Now.ToLongDateString();  // retorna um formato estendido da data
            //lblResultado.Text = DateTime.Now.ToShortDateString();  // retorna um formato reduzido da data
            //lblResultado.Text = DateTime.Now.ToLongTimeString();  // retorna o horario estendido com os segundos
            //lblResultado.Text = DateTime.Now.ToShortTimeString();  // retorna o horario reduzido sem os segundos
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //lblResultado.Text = DateTime.Now.ToString("dd-MM-yyyy   HH:mm");   //Possivel a formatação da data e hora

            //DateTime data = new DateTime(1991, 12, 27, 3, 20, 10);

            //lblResultado.Text = DateTime.Now - data.AddYears(33).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = data.Add(tempo).ToString();

            //lblResultado.Text = data.DayOfWeek.ToString();

            //lblResultado.Text = data.DayOfYear.ToString();

            //-- Quanto tempo falta para o meu aniversario --//

            DateTime data = new DateTime(2024, 12, 27, 3, 20, 10);
            DateTime now = DateTime.Now;
           
            TimeSpan falta = data - now;

            lblResultado.Text = falta.ToString(@"dd\.hh\:mm\:ss");
            //OBS: O ponto (.) e os dois pontos (:) são caracteres especiais que precisam ser escapados com uma barra invertida (\) para serem exibidos literalmente na saída.
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            //Color cor1 = Color.FromArgb(125, Color.DarkGreen);
            //Color cor1 = Color.FromArgb(125, 0,0,255);  // transparencia, cores red, green e blue;
            Color cor1 = Color.FromArgb(100, 50, 135); // considera a tranpasrencia 255
            Color cor2 = Color.FromKnownColor(KnownColor.Control);  // cores conhecidas do sistema
            Color cor3 = Color.FromName("DarkRed");

            lblResultado.BackColor = cor3;
            lblResultado.ForeColor = cor2;

            Color cor4 = lblResultado.BackColor;
            Color cor5 = lblResultado.ForeColor;

            btnColor.BackColor = cor4;
            btnColor.ForeColor = cor5;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Helvetica, Arial, sans-serif", 36, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Regular, GraphicsUnit.Pixel);

            lblResultado.Text = "Bem vindo ao C#, Trabalho com fontes";

            lblResultado.Font = letra2;
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  //retorna pastas do sistemas

            //Environment.CurrentDirectory = "C:\\"; // Possivel a formatação da info
            //string dirAtual = Environment.CurrentDirectory; //retorna odiretorio atula
            //Environment.NewLine; //Função semelhante ao "\n"
            //string varAmb = Environment.GetEnvironmentVariable("Path"); //Entrega toda informação de pastas do sistema
              
            //string[] discos = Environment.GetLogicalDrives(); // retorna todos os discos que tem na maquina
           
            //foreach (string item in discos)
            //{
            //    lblResultado.Text += "\n" + item;
            //}

            string user = Environment.UserName;  // retorna o username do usuario
            string dominio = Environment.UserDomainName;  //retorna o nome do pc na rede
            int cpu = Environment.ProcessorCount;  //retorna um numero inteiro de nucleos

            lblResultado.Text = cpu.ToString();        
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            //Application.Exit(); //finaliza aplicações

            string exec = Application.ExecutablePath;  //retorna o caminho do executavel

            string pasta = Application.StartupPath;  //retorna uma string mostrando a pasta onde esta

            Application.Restart(); //Forçar iniciação da aplicação

            lblResultado.Text = pasta;

        }
    }
}
