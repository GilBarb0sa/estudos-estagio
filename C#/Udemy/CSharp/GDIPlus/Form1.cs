using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GDIPlus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDesenhar_Click(object sender, EventArgs e)
		{
			//Folha em branco
			Bitmap folha = new Bitmap(picture.Width, picture.Height); //cria-se o objeto que gerará a imagem

			//Criar desenhador
			Graphics desenhador = Graphics.FromImage(folha);  //cria-se o esenhador para a folha

			//Desenhar a folha
			desenhador.Clear(Color.White);  //utiliza o desenhador com o metodo clear para pintar a folha

			#region Linhas

			//Brush pincel1 = new SolidBrush(Color.Red);
			//Pen lapis1 = new Pen(pincel1, 5);
			//Point ponto1 = new Point(100, 200);
			//Point ponto2 = new Point(400, 10);

			//Pen lapis2 = new Pen(Color.Black, 10);

			//Point ponto3 = new Point(0, 0);
			//Point ponto4 = new Point(100, 200);

			////desenhador.DrawLine(lapis1, ponto1, ponto2 );
			////desenhador.DrawLine(lapis2, ponto3, ponto4);

			//Point[] pontos =
			//{
			//	new Point(50,50),
			//	new Point(250,50),
			//	new Point(250,150),
			//	new Point(100,80),
			//	new Point(85,140),
			//};

			//desenhador.DrawLines(lapis1, pontos);

			#endregion

			#region Retangulos

			//Pen lapis = new Pen(Color.Black, 5);
			//Pen lapis2 = new Pen(Color.Red, 8);
			//Rectangle rect1 = new Rectangle(100, 50, 300, 200); //int x, y, width, heigth
			//Rectangle rect2 = new Rectangle(50, 250, 120, 40);
			//Rectangle rect3 = new Rectangle(120, 20, 145, 100);
			//Rectangle rect4 = new Rectangle(75, 200, 250, 100);

			////desenhador.DrawRectangle(lapis, rect1);
			////desenhador.DrawRectangle(lapis2, 0, 0, 250, 250);

			//Rectangle[] retangulos =
			//{
			//	rect1 , rect2 , rect3 , rect4 , new Rectangle(10, 30, 240, 85)
			//};

			////desenhador.DrawRectangles(lapis, retangulos);

			//Brush pincel = new SolidBrush(Color.Green);  //preenche o cor interna do retangulo.
			//Brush pincel2 = new LinearGradientBrush(rect4, Color.Green, Color.Yellow, 45);

			//desenhador.FillRectangles(pincel2, retangulos);

			#endregion

			#region Ellipse e Circulos

			//Pen lapis1 = new Pen(Color.Black, 5);
			//Rectangle rect1 = new Rectangle(220, 100, 250, 250);

			////desenhador.DrawRectangle(lapis1, rect1);
			//desenhador.DrawEllipse(lapis1, rect1);

			//Brush pincel1 = new SolidBrush(Color.Yellow);		
			//desenhador.FillEllipse(Brushes.Aqua, rect1);

			#endregion

			#region Poligonos

			//Pen lapis = new Pen(Color.Black, 5);

			//Point[] pontos =
			//{
			//	new Point(100, 100),
			//	new Point(300, 120),
			//	new Point(250, 150),
			//	new Point(150, 200),
			//	new Point(80, 130)
			//};

			//desenhador.DrawPolygon(lapis, pontos);

			//Brush pincel = new LinearGradientBrush(new Rectangle(100, 100, 100, 130),Color.Blue, Color.Yellow, 45);
			//desenhador.FillPolygon(pincel, pontos);

			#endregion

			#region Curvas

			//Pen lapis = new Pen(Color.Black, 5);
			//Point[] pontos =
			//{
			//	new Point(100, 50),
			//	new Point(125, 75),
			//	new Point(150, 100),
			//	new Point(125, 125),
			//	new Point(100, 150),
			//	new Point(75, 125),
			//	new Point(100, 50)
			//};

			////desenhador.DrawCurve(lapis, pontos, 1f);
			////desenhador.DrawClosedCurve(lapis, pontos, 1f,FillMode.Alternate);
			//desenhador.FillClosedCurve(Brushes.Yellow, pontos, FillMode.Winding,1.5f);

			#endregion

			#region Arcos

			//Pen lapis = new Pen(Color.Black, 5);
			//Rectangle rect = new Rectangle(100, 100, 300, 250);

			//desenhador.DrawRectangle(lapis, rect);
			//desenhador.DrawArc(lapis, rect, 270f, 90f);

			#endregion

			#region Bezier

			//Pen lapis = new Pen(Color.Black, 5);
			//Point p1 = new Point(50, 300);
			//Point p2 = new Point(200, 400);
			//Point p3 = new Point(300, 10);
			//Point p4 = new Point(500, 100);

			////desenhador.DrawBezier(lapis, p1, p2, p3, p4);

			//Point[] pontos =
			//{
			//	new Point(50,300),  //inicio
			//	new Point(150, 350),
			//	new Point(300, 100),
			//	new Point(400, 150), //meio
			//	new Point(500, 400),
			//	new Point(550, 10),
			//	new Point(600, 100)  //fim
			//};

			//desenhador.DrawBeziers(lapis, pontos);

			#endregion

			#region PIE

			//Pen lapis = new Pen(Color.Black, 4);
			//Rectangle rect = new Rectangle(50, 50, 300, 300);

			////desenhador.DrawPie(lapis, rect, 0, 90);

			//desenhador.FillPie(Brushes.Red, rect, 0, 315);
			//desenhador.DrawRectangle(lapis, rect);

			#endregion

			#region Path

			//Pen lapis = new Pen(Color.Black, 4);
			//GraphicsPath graficsPath = new GraphicsPath(FillMode.Winding);

			//graficsPath.AddEllipse(new RectangleF(10, 10, 150, 150));
			//graficsPath.AddEllipse(new RectangleF(200, 10, 150, 150));
			//graficsPath.AddRectangle(new RectangleF(400, 50, 200, 200));

			////desenhador.DrawPath(lapis, graficsPath);
			//desenhador.FillPath(Brushes.Red, graficsPath);

			#endregion

			#region Strings

			//string nome = "Gilberto Barbosa da Silva Filho";
			//string curso = "Análise e Desenvolvimento de Sistemas";
			//Font letra = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Point);
			//Brush pincel = new LinearGradientBrush(new Rectangle(0,0,400,400), Color.Red, Color.Blue, 45); //Faz um efeito gradiente na letra
			//Point ponto = new Point(50, 100);
			//Rectangle rect = new Rectangle(10, 20, 650, 400);
			//Rectangle rect2 = new Rectangle(10, 150, 650, 400); 
			//StringFormat alinhamento = new StringFormat();

			//alinhamento.Alignment = StringAlignment.Center;
			//alinhamento.LineAlignment = StringAlignment.Near;

			//desenhador.DrawRectangle(new Pen(Color.Black), rect);

			//desenhador.DrawString( nome, letra, pincel, rect, alinhamento );
			//desenhador.DrawString( curso, letra, pincel, rect2, alinhamento );

			#endregion

			#region

			Image imgOrigem1 = Image.FromFile(Application.StartupPath + @"\imagens\castle.jpg");
			Rectangle origem1 = new Rectangle(0, 0, imgOrigem1.Width, imgOrigem1.Height);
			Rectangle destino1 = new Rectangle(0, 0, picture.Width, picture.Height);

			Image imgOrigem2 = Image.FromFile(Application.StartupPath + @"\imagens\got.jpg");
			Rectangle origem2 = new Rectangle(270, 220, 145, 385); //A imagem que será recortado
			Rectangle destino2 = new Rectangle(50, 50, 145, 385);  //Onde será inserido na outra imagem

			desenhador.DrawImage(imgOrigem1, destino1, origem1, GraphicsUnit.Pixel);
			desenhador.DrawImage(imgOrigem2, destino2, origem2, GraphicsUnit.Pixel);

			#endregion

			//Utilizar num picture Box
			picture.BackgroundImage = folha;

			//Salvar desenho num arquivo
			folha.Save(@"C:\Users\40357200896\Documents\Gilberto\desenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg); //salvar em formato de arquivo
		}
	}
}
