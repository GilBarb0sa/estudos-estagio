using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			ListViewItem item1 = new ListViewItem("Gilberto");
			item1.SubItems.Add("12-9999-9999");
			item1.SubItems.Add("gilbarbosafilho@gmail.com");


			ListViewItem item2 = new ListViewItem("Islaine");
			item2.SubItems.Add("13-99654-9229");
			item2.SubItems.Add("islaineamir@gmail.com");


			ListViewItem item3 = new ListViewItem("Saskaroth");
			item3.SubItems.Add("13-13598-9999");
			item3.SubItems.Add("saskarothgod@gmail.com");

			ListViewItem item4 = new ListViewItem(new string[]
				{ "Arthur", "13-99875-5674", "arthurdurval@hotmail.com" }
			);

			lista.Items.Add(item1);
			lista.Items.Add(item2);
			lista.Items.Add(item3);
			lista.Items.Add(item4);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//lista.Items.Clear();  //Apagar toda a lista
			//lista.Items.Remove(lista.SelectedItems[0]);  //Remove só o item selecionado
			lista.Items.RemoveAt(1);  //Deleta conforme o indice
		}

		private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show(lista.SelectedItems[0].Text);  //Realiza um evento ao clicar em algum campo da lista
		}
	}
}
