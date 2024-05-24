using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object DataTime { get; private set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);  //Gera um número aleátorio na label1 a cada 3 segundos no timer
            label1.Text = r.Next(100).ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
