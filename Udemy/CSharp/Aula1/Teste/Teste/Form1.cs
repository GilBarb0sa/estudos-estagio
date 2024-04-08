using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Text = "Gilberto Barbosa";
            //this.Size = new Size(400, 200);
            //this.ControlBox = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando na Form";
            this.Size = new Size(450, 200);
        }
    }
}
