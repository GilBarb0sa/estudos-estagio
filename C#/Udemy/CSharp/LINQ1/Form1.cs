using System;
using System.Collections.Generic;
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
			lista_numeros.Add(1);
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
			lista_estados.Add("New York", "Estados Unidos");
			lista_estados.Add("São Paulo", "Brasil");
			lista_estados.Add("Porto", "Portugal");
			lista_estados.Add("Lisboa", "Portugal");
			lista_estados.Add("Bahia", "Brasil");
			lista_estados.Add("Washington", "Estados Unidos");
			lista_estados.Add("Algarve", "Portugal");
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
			var res = from nome in lista_nomes
					  orderby nome ascending
					  where nome.ToLower().Contains(txt)
					  select nome;

			foreach (var n in res)
			{
				lista.Items.Add(n);
			}

		}

		private void btnOrderBy_Click(object sender, EventArgs e)
		{
			// Operador de Ordenação
			lista.Items.Clear();
			string txt = txtConsulta.Text;

			//var res = from num in lista_numeros 
			//		  orderby num  //orderby ordena a consulta
			//		  where num <= 10
			//		  select num;  //realiza uma consulta

			//foreach (var n in res)
			//{
			//	lista.Items.Add(n);
			//}

			var res = from produto in lista_produtos
					  orderby produto.Key ascending
					  select produto;

			foreach (KeyValuePair<string, double> item in res)
			{
				lista.Items.Add(item.Key + "R$" + item.Value);
			}
		}

		private void btnGroupBy_Click(object sender, EventArgs e)
		{
			// Operadores de Agrupamento
			lista.Items.Clear();
			txtConsulta.Text = "";

			var res = from estado in lista_estados
					  group estado by estado.Value;

			foreach (var grupo in res)
			{
				lista.Items.Add(grupo.Key);
				foreach (var estado in grupo)
				{
					lista.Items.Add("     " + estado.Key);
				}
			}

		}

		private void btnAgregacao_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();

			//int cont1 = lista_nomes.Count();
			//int cont2 = (from nome in lista_nomes where nome.StartsWith("G") select nome).Count();

			//lista.Items.Add(cont1 + " nomes.");
			//lista.Items.Add(cont2 + " nomes começados com a letra G.");  //filtragem apresentando as palavras que inicia com a letra G

			//double media1 = lista_numeros.Average();
			//lista.Items.Add(media1 + " média dos valores na lista de números.");  //Média dos valores da lista

			//var res1 = from num in lista_numeros where num < 10 select num;
			//double media2 = res1.Average();
			//lista.Items.Add(media2 + " média menores que 10.");  // Média dos valores num certo grupo de itens

			//int soma1 = lista_numeros.Sum();
			//lista.Items.Add(soma1 + "  soma dos valores.");  // Soma de todos os valores de todos os itens

			//var res2 = from num in lista_numeros where num < 10 select num;
			//int soma = res2.Sum();
			//lista.Items.Add(soma + "  soma dos valores < 10."); // Soma dos valores num certo grupo de itens

			// Também aplicados nas consultas.
			//lista.Items.Add(lista_numeros.Min() + " valor minimo em lista de números.");
			//lista.Items.Add(lista_numeros.Max() + " valor máximo em lista de números.");

			// Também aplicados nas consultas.
			//long contagem = lista_numeros.LongCount();


			// Também aplicados nas consultas.
			string maiorNome = lista_nomes.Aggregate((maior, proximo) =>
			{
				if (maior.Length > proximo.Length)
				{
					return maior;
				}
				else
				{
					return proximo;
				}

			});
			lista.Items.Add(maiorNome + " é o maior nome da lista.");

			string menorNome = lista_nomes.Aggregate((menor, proximo) =>
			{
				if (menor.Length < proximo.Length)
				{
					return menor;
				}
				else
				{
					return proximo;
				}

			});
			lista.Items.Add(menorNome + " é o menor nome da lista.");
		}

		private void btnOperadoresDeElementos_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();

			int primeiro = lista_numeros.FirstOrDefault();  //Apresenta o primeiro numero da lista
			lista.Items.Add(primeiro);

			int ultimo = lista_numeros.LastOrDefault(); //Apresenta o ultimo numero da lista
			lista.Items.Add(ultimo);

			int elemento = lista_numeros.ElementAt(3);  //Apresenta o numero na posição 3
			lista.Items.Add(elemento);

			var consulta = from num in lista_numeros where num > 100 select num;  //Faz uma busca se na lista tem o numero senão apresenta um numero padrão, 0!
			int numero = consulta.FirstOrDefault();
			lista.Items.Add(numero);
		}

		private void btnLinqLambda_Click(object sender, EventArgs e)
		{
			//var cons1 = from nome in lista_nomes select nome;  //Consulta comum
			//var cons1 = lista_nomes.Select(nome => nome);  //nome da lista de nomes retorna o nome, usando operação lambda
			//lista.Items.AddRange(cons1.ToArray());

			//var cons2 = from nome in lista_nomes where nome.StartsWith("G") select nome;
			//var cons2 = lista_nomes.Where((nome) => nome.StartsWith("G"));  //consulta com o metodo where junto lambda.
			//lista.Items.AddRange(cons2.ToArray());

			//var cons3 = from nome in lista_nomes orderby nome select nome;
			//var cons3 = lista_nomes.OrderByDescending(nome => nome);  //Faz uma consulta com ordenação do nome junto com operação lambda
			//lista.Items.AddRange(cons3.ToArray());

			//var cons4 = from estado in lista_estados group estado by estado.Value;  //agrupa a lista de estados pelo value que é o pais nesta lista
			var cons4 = lista_estados.GroupBy(estado => estado.Value);  //Com operador lambda			
			foreach( var grupo in cons4)
			{
				lista.Items.Add(grupo.Key);  //chave do pais
				foreach(var estado in grupo)
				{
					lista.Items.Add("     " + estado.Key); //chave para estados
				}
			}

		}
	}
}
