using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (font.ShowDialog() != DialogResult.Cancel)  //Se o evento for diferente ao cancel ele abrirá uma caixa de dialogo de Fonte!
            {
                label1.Font = font.Font; 
                label1.ForeColor = font.Color;  //insere na caixa de dialogo opção de cor
            }
            
        }

        private void font_Apply(object sender, EventArgs e)  //Da para aplicar para visualizar comon ficar o estilo da fonte sem fechar a caixa de dialogo
        {
            label1.Font = font.Font;
            label1.ForeColor = font.Color;
        }
    }
}
