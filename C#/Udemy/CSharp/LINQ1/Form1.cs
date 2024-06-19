using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace LINQ1
{
	public partial class Form1 : Form
	{
		readonly List<string> lista_nomes;
		readonly List<int> lista_numeros;
		readonly Dictionary<string, double> lista_produtos;
		readonly Dictionary<string, string> lista_estados;

		public Form1()
		{
			InitializeComponent();

			#region Lista de Nomes
			lista_nomes = new List<string>();
			lista_nomes.Add("Gil");
			lista_nomes.Add("Islaine");
			lista_nomes.Add("Marineuza");
			lista_nomes.Add("Gilberto");
			lista_nomes.Add("Juliana");
			lista_nomes.Add("Matheus");
			lista_nomes.Add("Rafael");
			lista_nomes.Add("Bruno");
			lista_nomes.Add("Rodrigo");
			lista_nomes.Add("Meire");
			lista_nomes.Add("Mader");
			lista_nomes.Add("Davi");
			lista_nomes.Add("Gabriel");
			lista_nomes.Add("Miguel");
			lista_nomes.Add("Rose");
			lista_nomes.Add("Carol");
			lista_nomes.Add("João");
			lista_nomes.Add("Tiago");
			lista_nomes.Add("Larissa");
			lista_nomes.Add("Daiane");
			#endregion

			#region Lista Números
			lista_numeros = new List<int>();
			lista_numeros.Add(0);
			lista_numeros.Add(2);
			lista_numeros.Add(8);
			lista_numeros.Add(4);
			lista_numeros.Add(12);
			lista_numeros.Add(37);
			lista_numeros.Add(98);
			lista_numeros.Add(13);
			lista_numeros.Add(22);
			lista_numeros.Add(7);
			lista_numeros.Add(21);
			lista_numeros.Add(54);
			#endregion

			#region Lista Produtos
			lista_produtos = new Dictionary<string, double>();
			lista_produtos.Add("Teclado USB", 49.95);
			lista_produtos.Add("Teclado PS2", 45.95);
			lista_produtos.Add("Teclado Gamer", 358.99);
			lista_produtos.Add("Mouse", 29.5);
			lista_produtos.Add("Monitor", 780.85);
			lista_produtos.Add("Memória 16Gb", 700.00);
			lista_produtos.Add("Memória 8Gb", 375.65);
			lista_produtos.Add("Processador", 1250);
			lista_produtos.Add("Placa Mãe", 150);
			lista_produtos.Add("Gabinete", 190);
			#endregion

			#region Lista Estados
			lista_estados = new Dictionary<string, string>();
			lista_estados.Add("Rio de Janeiro", "Brasil");
			lista_estados.Add("New York","Estado Unidos");
			lista_estados.Add("São Paulo","Brasil");
			lista_estados.Add("Porto","Portugal");
			lista_estados.Add("Lisboa","Portugal");
			lista_estados.Add("Bahia","Brasil");
			lista_estados.Add("Washington","Estados Unidos");
			lista_estados.Add("Algarve","Portugal");
			#endregion
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{	
			lista.Items.Clear();

			//Obter a fonte dos dados
			//Criar a consulta
			//Executar a consulta.

			//    --Metodo Comum--
			//foreach (int num in lista_numeros)
			//{
			//	if(num % 2 == 0)
			//	{
			//		lista.Items.Add(num);
			//	}
			//}

			//    --Metodo LINQ--
			//IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;  //Uma consulta onde o numero da lista for par, irá retornar

			//foreach(int n in res)
			//{
			//	lista.Items.Add(n);
			//}


			//    --Metodo LINQ--
			string txt = txtConsulta.Text;
			IEnumerable<string> res2 = from nome in lista_nomes where nome.StartsWith(txt) select nome;

			lista.Items.AddRange(res2.ToArray()); //Uma forma mais simples puxando a lista como se fosse uma array

			//foreach (string n in res2)
			//{
			//	lista.Items.Add(n);
			//}

		}

		private void btnWhere_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();

			//Operador de Filtragem, a clausula Where

			string txt = txtConsulta.Text.ToLower();
			var res = from nome in lista_nomes where nome.ToLower().Contains(txt) select nome;

			//lista.Items.AddRange((res.ToArray()).ToArray());

			foreach (var n in res)
			{
				lista.Items.Add(n);
			}

		}
	}
}
