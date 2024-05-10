using System;
using System.Threading;
using System.Windows.Forms;

namespace Formularios
{
	public partial class FormSegunda : Form
	{
		public string Mensagem {  get; set; }

		public FormSegunda()
		{
			InitializeComponent();
		}

        public FormSegunda(string mensagem)
        {
            InitializeComponent();

			this.Mensagem = mensagem;
        }

        private void FormSegunda_Load(object sender, EventArgs e)
		{
			txtMensagem.Text = Mensagem;
		}

		private void btnPrincipal_Click(object sender, EventArgs e)
		{
			this.Close(); //Encerra esta tela e passa para a anterior
			Thread t = new Thread(() => Application.Run(new FormMain())); //Utiliza metodo de arranque para estanciar
			t.Start();
		}

		private void btnRetorno_Click(object sender, EventArgs e)
		{
			if (txtMensagem.Text == "" || txtMensagem.Text == null)
			{
				Mensagem = null;
			}
			else
			{
				Mensagem = txtMensagem.Text;
			}

			Close();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Mensagem = null;
			Close();
		}
	}
}
