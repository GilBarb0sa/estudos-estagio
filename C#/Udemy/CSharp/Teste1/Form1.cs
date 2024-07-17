using System;
using System.Windows.Forms;

namespace Teste1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{
			Matematica.Valor1 = 100;
			Matematica.Valor2 = 2;

			listaResultado.Items.Add("Somar: " + Matematica.Somar());
			listaResultado.Items.Add("Subtração: " + Matematica.Subtrair());
			listaResultado.Items.Add("Multiplicação: " + Matematica.Multiplicar());
			listaResultado.Items.Add("Divisão: " + Matematica.Dividir());
		}
	}
}
