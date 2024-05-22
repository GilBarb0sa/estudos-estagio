using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte020
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Criação de uma tela de navegação pelo browser, com uma url, botão de ir, volta e avançar

		private void btnGo_Click(object sender, EventArgs e)
		{
			string url = txtURL.Text;
			browser.Navigate("http://" + url);
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			browser.GoBack();
		}

		private void btnAvancar_Click(object sender, EventArgs e)
		{
			browser.GoForward();
		}
	}
}
