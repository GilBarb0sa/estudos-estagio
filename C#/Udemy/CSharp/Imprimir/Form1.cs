using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Imprimir
{
	public partial class Form1 : Form
	{
		int x;
		int y;
		int largura;
		int altura;
		int num_linhas;
		int pagina;
		int num_paginas;

		public Form1()
		{
			InitializeComponent();
			pagina = 0;
			num_paginas = 0;
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			altura = printDocument1.DefaultPageSettings.Bounds.Height;
			largura = printDocument1.DefaultPageSettings.Bounds.Width;
			x = 50;
			y = 50;
			num_linhas = 0;

			printDialog1.Document = printDocument1;
			if (printDialog1.ShowDialog() != DialogResult.Cancel)  //Escolha qual impressora será impressa
			{
				altura = printDocument1.DefaultPageSettings.Bounds.Height;
				largura = printDocument1.DefaultPageSettings.Bounds.Width;

				printDocument1.PrinterSettings = printDialog1.PrinterSettings;
				printDocument1.Print();
			}

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

			//int x = printDocument1.DefaultPageSettings.Bounds.X;
			//int y = printDocument1.DefaultPageSettings.Bounds.Y;
			//int altura = printDocument1.DefaultPageSettings.Bounds.Height;
			//int largura = printDocument1.DefaultPageSettings.Bounds.Width;

			//string titulo = "Titulo da Página";
			//Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			//Brush pincelTitulo = new SolidBrush(Color.Red);
			//Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, altura - 100);
			//StringFormat formatoTitulo = new StringFormat();
			//formatoTitulo.Alignment = StringAlignment.Center;
			//formatoTitulo.LineAlignment = StringAlignment.Center;

			//string txt = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
			//Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
			//Brush pincel = new SolidBrush(Color.Black);
			//Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);

			////Desenhar o documento para ser impresso
			//e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatoTitulo);
			//e.Graphics.DrawString(txt, letra, pincel, areaTexto);
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

			#endregion

			#region Parte 3

			List<string> linhas = new List<string>()
			{
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"11. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"1. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"2. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"3. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"4. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"5. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"6. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"7. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"8. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"9. Lorem ipson dolor sit amet consectetur dipisicing elit.",
				"10. Lorem ipson dolor sit amet consectetur dipisicing elit."				
			};

			string titulo = "Titulo da Página";
			Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			Brush pincelTitulo = new SolidBrush(Color.Red);
			Rectangle areaTitulo = new Rectangle(x, y, largura - 100, 100);
			StringFormat formatoTitulo = new StringFormat();
			formatoTitulo.Alignment = StringAlignment.Center;
			formatoTitulo.LineAlignment = StringAlignment.Center;

			////Desenhar o documento para ser impresso
			//e.Graphics.DrawString(txt, letra, pincel, areaTexto);

			Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
			Brush pincel = new SolidBrush(Color.Black);

			while (num_linhas < linhas.Count)
			{
				if(num_linhas == 00)
				{
					e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatoTitulo);
					y += 150;
				}

				e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x,y));
				y += 30; //colocando um distanciamento de uma linha para a outra
				num_linhas++;

				if (y >= altura -50)  //Este if é responsavel por imprimir novas paginas se tiver novas paginas
				{
					// Mudar de página
					y = 50;
					e.HasMorePages = true;  
					num_paginas++;
					break;
				}
			}

			#endregion
		}

		private void btnVisualizar_Click(object sender, EventArgs e)  //Pré visualização do documento
		{
			altura = printDocument1.DefaultPageSettings.Bounds.Height;
			largura = printDocument1.DefaultPageSettings.Bounds.Width;
			x = 50;
			y = 50;
			num_linhas = 0;

			printPreviewControl1.Document = printDocument1;
		}

		private void btnAnterior_Click(object sender, EventArgs e)  //Visualizar a pagina anterior
		{
			if (pagina > 0)
			{
				printPreviewControl1.StartPage = --pagina;
			}
		}

		private void btnProximo_Click(object sender, EventArgs e) //Visualizar a pagina seguinte
		{
			if (pagina < num_paginas)
			{
				printPreviewControl1.StartPage = ++pagina;
			}
		}

		private void btnVisualizarPadrao_Click(object sender, EventArgs e)
		{
			altura = printDocument1.DefaultPageSettings.Bounds.Height;
			largura = printDocument1.DefaultPageSettings.Bounds.Width;
			x = 50;
			y = 50;
			num_linhas = 0;

			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
		}
	}
}
