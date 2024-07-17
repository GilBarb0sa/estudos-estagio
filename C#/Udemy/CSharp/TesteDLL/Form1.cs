using Operacoes;
using System;
using System.Windows.Forms;

namespace TesteDLL
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{
			Matematica.Valor1 =  50;
			Matematica.Valor2 = 15;

			label1.Text = Matematica.Somar().ToString();
		}
	}
}
