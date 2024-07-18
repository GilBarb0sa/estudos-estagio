using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoStringMD5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCriptografar_Click(object sender, EventArgs e)
		{
			CriptoMD5 md5 = new CriptoMD5();
			txtSaida.Text = md5.RetornarMD5(txtEntrada.Text);
		}

		private void btnComparar_Click(object sender, EventArgs e)
		{
			string senhaBanco = "86194202161135641414324525317778516216718";  //Gilberto
			string senha = txtEntrada.Text;

			CriptoMD5 md5 = new CriptoMD5();
			bool res = md5.CompararMD5(senha, senhaBanco);

			if(res) 
			{
				labelResultado.Text = "Senhas iguais";
			}
			else
			{
				labelResultado.Text = "Senhas Diferentes";
			}
		}
	}
}
