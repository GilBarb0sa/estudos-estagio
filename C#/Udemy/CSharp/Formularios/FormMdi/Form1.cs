using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMdi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FormDois f = new FormDois(this);  // criando um novo objeto --- o this no metodo faz com o que o FormDois tenha o Form1 como parent
			//f.MdiParent = this;  //Instancia um form dentro da principal
			f.Show();
		}
	}
}
