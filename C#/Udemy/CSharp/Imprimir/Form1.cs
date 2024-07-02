using System;
using System.Drawing;
using System.Windows.Forms;

namespace Imprimir
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			printDocument1.Print();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			#region Parte 1

			//string txt = "Trabalhando com impressão.";
			//Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
			//Brush pincel = new SolidBrush(Color.Black);
			//Point pontoInicial = new Point(100, 50);

			////Desenhar o documento para ser impresso
			//e.Graphics.DrawString(txt, letra, pincel, pontoInicial);
			//e.Graphics.DrawString("Gilberto", letra, Brushes.Blue, new Point(100, 150));
			//e.Graphics.FillRectangle(Brushes.Red, new Rectangle(100, 200, 350, 100));

			#endregion

			#region Parte 2

			int x = printDocument1.DefaultPageSettings.Bounds.X;
			int y = printDocument1.DefaultPageSettings.Bounds.Y;
			int altura = printDocument1.DefaultPageSettings.Bounds.Height;
			int largura = printDocument1.DefaultPageSettings.Bounds.Width;

			string titulo = "Titulo da Página";
			Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			Brush pincelTitulo = new SolidBrush(Color.Red);
			Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, altura - 100);
			StringFormat formatoTitulo = new StringFormat();
			formatoTitulo.Alignment = StringAlignment.Center;
			formatoTitulo.LineAlignment = StringAlignment.Center;

			string txt = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
			Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
			Brush pincel = new SolidBrush(Color.Black);
			Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);

			//Desenhar o documento para ser impresso
			e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatoTitulo);
			e.Graphics.DrawString(txt, letra, pincel, areaTexto);
			e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);
			e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

			#endregion
		}
	}
}
