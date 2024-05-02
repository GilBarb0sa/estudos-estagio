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
            lista.Items.Clear();
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Danny"},
                {200, "Arthur"},
                {80, "Danny"}
            };

            alunos.Add(100, "Gabriel");

            //alunos.ContainsKey(80);  // Verifica se existe x Key

            if(alunos.ContainsValue("Arthur"))
            {
                MessageBox.Show("Contém o aluno");
            }
            else
            {
                MessageBox.Show("Não contém o aluno");
            }

            // alunos.Remove(80); //Remove algum item especifico
            //alunos.Clear();  //limpa toda a lista

            //KeyValuePair<int, string> primeiro = alunos.First();
            //MessageBox.Show("Primeiro " + primeiro.Key + " " + primeiro.Value); // Retorna o primeiro item

            //MessageBox.Show("Último " + alunos.Last().Key + " " + alunos.Last().Value); // Retorna o último item

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }

           // MessageBox.Show("Quantidade de alunos: " + alunos.Count); //conta quantos itens tem na lista
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear(); //Limpa a lista sempre ao iniciar

            SortedList<int, string> alunos = new SortedList<int, string>() // SortedList coloca os itens em ordem pela key
            {
                { 27, "Danny" },
                { 10, "Gabriel" },
                { 17, "Arhtur" }
            };

            alunos.Add(14, "Glória");
            // alunos.Reverse();  // utiliza no final do foreach para reverter a ordem das keys

            //alunos.Remove(10); //Remove pela key
            //alunos.RemoveAt(0); // Remove pelo indice, pois o SortedList ele já contem indice os seus itens.

            //alunos.CountainsKey(50);  // É um metodo bolleano que verifica se tem esta key, podendo ser utilizado em um if
            //alunos.CountainsValue("Danny");  // mesma coisa só que com value

            MessageBox.Show("A lista tem " + alunos.Count + " alunos.");



            foreach (KeyValuePair<int, string> item in alunos  )
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>() // Inseri os itens na ordem crescente, e tem ordena pelo alfabeto
            {
                { 57144, "Gilberto" },
                { 1548, "Islaine" },
                { 25, "Juliana" }
            };

            alunos.Add(154, "Matheus");

            //alunos.Remove(120);
            //alunos.Count;
            //alunos.Clear();
            //alunos.ContainsKey(25);
            //alunos.ContainsValue("Gilberto");

            MessageBox.Show(alunos.ElementAt(0).ToString()); // Entrega o item conforme o indice, e to utilizando .ToString para converte-lo para string

            foreach(KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Gilberto", "Islaine", "Matheus", "Juliana", "Marineuza"
            };

            if(!nomes.Add("GilbertoPai"))
            {
                MessageBox.Show("Não se repete nomes, pois dará false");
            }

            //nomes.Reverse();
            //nomes.Remove("Juliana");
            //nomes.ElementAt(2); //Apresenta o item do indice solicitado
            //nomes.First();
            //nomes.Last();
            //nomes.Clear();

            MessageBox.Show("Essa lista contém " + nomes.Count.ToString() + " nomes.");

            foreach(string nome in nomes )
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear ();
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Gilberto");
            fila.Enqueue("Islaine");
            fila.Enqueue("Juliana");
            fila.Enqueue("Matheus");
            fila.Enqueue("Marineuza");

            MessageBox.Show(fila.Count.ToString());

            foreach( string item in fila )
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show("Primeiro da fila: " + fila.Peek());  //Apresenta o item mas não o remove
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila: " + fila.Dequeue());  //Apresenta o item e o remove da fila, sempre o primeiro que entra é o primeiro que sai
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila: " + fila.First());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Úlitmo da fila " + fila.Last());
            //MessageBox.Show(fila.Count.ToString());

            //fila.Clear();

            while (fila.Count > 0)   //Vai retirando um item por vez e apresentando quantos items tem depois de retirar
            {
                MessageBox.Show("Primeiro da fila: " + fila.Dequeue());
                MessageBox.Show(fila.Count.ToString());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();  //No metodo pilha o ultimo a entrar é o ultimo a sair!!!

            pilha.Push("Gilberto");
            pilha.Push("Islaine");
            pilha.Push("Juliana");
            pilha.Push("Matheus");
            pilha.Push("Marineuza");
            pilha.Push("GilbertoPai");

            MessageBox.Show(pilha.Count.ToString());

            foreach( string item in pilha )
            {
                lista.Items.Add(item);
            }

            //pilha.Clear();  // limpa toda pilha

            //MessageBox.Show("Elemento no topo " + pilha.Peek());  //Apresenta o elemento do topo
            //MessageBox.Show(pilha.Count.ToString() );

         
            while (pilha.Count > 0)  //Apresenta e retira o elemento até zerar
            {
                MessageBox.Show("Elemento no topo " + pilha.Pop()); //Apresenta o elemento do topo e o retira
                MessageBox.Show(pilha.Count.ToString());
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }
        }
    }
}
