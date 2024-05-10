using System;
using System.Threading;
using System.Windows.Forms;

namespace Formularios
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void btnSegunda_Click(object sender, EventArgs e)
		{	
			this.Hide();  //esconde a form principal ao abrir a segunda "Ter o cuidado pois o programa pode estar executando mesmo apos fechar, por uma das telas estar em HIDE!" 
			FormSegunda f = new FormSegunda("Bem Vindo!");
			//f.Mensagem = "Gilberto";
			//f.Form();
			f.ShowDialog();

			if (f.Mensagem != null)
			{
				lblTitulo.Text = f.Mensagem;
			}

			this.Show();  //ao fechar a form secundaria, apresenta a form principal
		}

		private void btnSegundaFormThread_Click(object sender, EventArgs e)
		{
			this.Close(); //Encerra esta tela e passa para a proxima
			Thread t = new Thread(() => Application.Run(new FormSegunda()));  //Utiliza metodo de arranque para estanciar
			t.Start();
		}

		private void mFileNovo_Click(object sender, EventArgs e)
		{
			new Thread(() => Application.Run(new FormMain())).Start();  //Cria uma nova estância
		}

		private void mFileAbrir_Click(object sender, EventArgs e)
		{
			Hide();
			FormSegunda f = new FormSegunda();
			f.ShowDialog();
			Show();
		}

		private void mFileSair_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mHelpSobreDev_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Gilberto Barbosa");
		}

		private void mHelpSobreVer_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Versão 1.0");
		}

		private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboMenu.SelectedIndex == 0)
			{
				menuFile.Text = "File";
				menuHelp.Text = "Help";
			}
			else if (comboMenu.SelectedIndex == 1)
			{
				menuFile.Text = "Archivo";
				menuHelp.Text = "Ayuda";
			}else
			{
				menuFile.Text = "Arquivo";
				menuHelp.Text = "Ajuda";
			}
		}

		private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				lblTitulo.Text = mPesquisar.Text;
				mPesquisar.Text = "";
			}
		}
	}
}
