using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Array
            string[] nomes = new string[3];
            nomes[0] = "Gilberto";
            nomes[1] = "Islaine";
            nomes[2] = "Gamora";

            // Lista Generica
            List<string> nomes2 = new List<string>();

            nomes2.Add("Natasha");
            nomes2.Add("Boneca");
            nomes2.AddRange(nomes); // Puxa toda lista de array  para a Lista generica

            #region Remover Manualmente
            //if (nomes2.Remove("Gilberto"))
            //{
            //    MessageBox.Show("Gilberto removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possivel remover");
            //}
            #endregion

            #region Metodo Contains
            //if (nomes2.Contains("Islaine"))
            //{
            //    MessageBox.Show("Contém!");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém!");
            //}
            #endregion

            //MessageBox.Show("Número de elementos : " + nomes2.Count); //Conta quantos elementos tem nesta lista

            //nomes2.Sort();  //Ordena as string em ordem crescente do alfabeto

            //MessageBox.Show("Boneca está no indice: " + nomes2.IndexOf("Boneca")); //Mostra o indice de algum elemento

            //nomes2.Insert(3, "Juliana"); //Inseri um novo elemento

            //nomes2.RemoveAt(3); // Remove o item pelo indice

            //nomes2.Clear(); //Remove tudo da lista

            nomes2.Add("Balta"); //adiciona um item no indice seguinte

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

           // MessageBox.Show(veiculos.ElementAt(2));

            //if (veiculos.Add("Cavalo"))
            //{
            //    MessageBox.Show("Item adicionado!");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado!");
            //}

            //if (veiculos.Contains("Carro"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém");
            //}

            //veiculos.Remove("");
            //veiculos.Count();
            //veiculos.Clear();
            //veiculos.First();
            //veiculos.Last();

            foreach(string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Danny"},
                {200, "Arthur"},
                {80, "Danny"}
            };

            alunos.Add(100, "Gabriel");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }
        }
    }
}
