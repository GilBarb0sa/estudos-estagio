using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;  // Que seja finalizada ao final da aplicação
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)  //Se a thread tarefa não estiver executando, então execute-a
            {
                t.Start();
            }
        }

        private void Tarefa()
        {
            while (true)
            {
                //lblResultado.Text = DateTime.Now.Second.ToString();
                //DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString()); //Este metodo é essencial para o funcionamento do contador!
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.Second.ToString()));
                //O codigo acima é uma forma resumida para mostrar o contador sem o uso do delegate ou metodo secundarios!!!
            }
            //DefinirValorPropriedade(lblResultado, "BackColor", Color.Red);
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)  //Metodo para atualizar o ambiente grafico
        {
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor});
            } 
            else
            {   // Este caso é se não necessitar do Invoke
                Type t = controle.GetType();  // obtem o tipo do controle
                PropertyInfo[] props = t.GetProperties(); // retorna um array com todas propriedades do controle

                foreach (PropertyInfo p in props) 
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);  // defini o valor da propriedade
                    }
                }
            }
        }
    }
}
