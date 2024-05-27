using System;
using System.Windows.Forms;

namespace Parte039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            //colorDialog1.Color = lblCor.BackColor;
            //btnCor.BackColor = colorDialog1.Color;

            if (colorDialog1.ShowDialog() != DialogResult.Cancel)   //Lógica para verificar se foi cancelado a caixa de dialogo de cores.
            {
                lblCor.BackColor = colorDialog1.Color;
                btnCor.BackColor= colorDialog1.Color;
            }
        }
    }
}
