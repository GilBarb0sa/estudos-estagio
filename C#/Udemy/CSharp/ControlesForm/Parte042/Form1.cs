using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.Filter = "Imagem png|*.png|Icone|*.ico|Icones e Fotos|*.ico;*.jpg|Todos os Arquivos|*.*";  //Filtro para abrir apenas tipos de arquivos expecificos

            if (open.ShowDialog() != DialogResult.Cancel)
            {
                //label1.Text = open.FileName;

                foreach (string item in open.FileNames)  //Puxa uma lista de array e imprimi varios arquivos senod impresso na tela
                {
                    listBox1.Items.Add(item);
                }
            }
           
        }
    }
}
