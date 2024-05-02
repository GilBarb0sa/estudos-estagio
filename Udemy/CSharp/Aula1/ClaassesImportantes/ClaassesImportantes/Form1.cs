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
    }
}
