using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte015
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{
			#region Parte1
			//Task parte1 = Task.Factory.StartNew(new Action(() =>
			//{
			//	Thread.Sleep(2000);  //Coloque a ação para dormir por 2seg, antes de iniciar
			//	progress.Invoke(new Action(() => progress.Value = 25)); // realiza a ação de preencher a progressbar
			//}));

			//Task parte2 = parte1.ContinueWith((x) =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 50));
			//});

			//Task parte3 = parte2.ContinueWith((x) =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 75));
			//});

			//Task parte4 = parte3.ContinueWith((x) =>
			//{
			//	Thread.Sleep(2000);
			//	progress.Invoke(new Action(() => progress.Value = 100));
			//});
			#endregion

			List<Task> tasks = new List<Task>();
			// Criado uma lista de tarefa 

			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(1000);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));
			// Cada tarefa terá um intervalo e foi avançando na progressbar com o metodo Invoke


			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(12500);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));


			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(1900);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));


			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(9999);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));


			tasks.Add(new Task(new Action(() =>
			{
				Thread.Sleep(6450);
				progress.Invoke(new Action(() => progress.PerformStep()));
			})));

			progress.Maximum = tasks.Count;
			progress.Step = 1;
			//Definido o maximo de progressbar, conforme a quantidade de tasks

			for (int i = 0; i < tasks.Count; i++)
			{
				tasks[i].Start();
			}
			//percore a lista de tarefas
		}
	}
}
