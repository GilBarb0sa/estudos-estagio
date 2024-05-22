using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte025
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("http://" + url1.Text);
			tabPage1.Text = url1.Text;
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			webBrowser2.Navigate("http://" + url2.Text);
			tabPage2.Text = url2.Text;
		}
	}
}
