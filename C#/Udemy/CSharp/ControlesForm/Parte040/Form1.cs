using System;
using System.Windows.Forms;

namespace Parte040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFolder_Click(object sender, EventArgs e)
        {
            if ( folder.ShowDialog() != DialogResult.Cancel )
            {
                lblFolder.Text = folder.SelectedPath;  //retorna o endereço da página selecionada, imrpimindo no próprio label
            }
        }
    }
}
