using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte006
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			checkList.Items.Add("Carro", true);
			checkList.Items.Add("Moto");
			checkList.Items.Add("Avião");
			checkList.Items.Add("Barco");


			int qtdItems = checkList.Items.Count;
			//MessageBox.Show("Quantidade de itens: " + qtdItems);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//checkList.Items.Clear();  // Apaga todos os itens da lista

			//checkList.Items.AddRange(new object[] { "Bike", "Mobilete", "Caminhão" }); //Adiciona uma coleção de obejetos

			//bool res = checkList.Items.Contains("Moto"); // Retorna um booleano se tem tal item
			//if (res)
			//{
			//	MessageBox.Show("Contem");
			//}

			//checkList.Items.Remove("Moto"); //Remove pelo objeto
			//checkList.Items.RemoveAt(2);  //Remove pelo indice

			//checkList.Items.Insert(1, "Cavalo"); //seleciona o indice e inseri o objeto

			var itens = checkList.CheckedItems;  //retorna todos os itens selecionado ma caixa de check
			//var itens = checkList.SelectedItems;  //retorna todos os itens somente selecionado
			foreach ( var item in itens )
			{
				MessageBox.Show(item.ToString());
			}
		}

		private void checkList_SelectedIndexChanged(object sender, EventArgs e)
		{
			label1.Text = checkList.SelectedItem.ToString();  //Reproduz o item selecionado em um label
		}
	}
}
