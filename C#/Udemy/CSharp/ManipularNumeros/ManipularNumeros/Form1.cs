using System;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num;
            ////bool res = int.TryParse("1991", out num);

            //if(int.TryParse("1991aaaa", out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}
            #endregion

            #region ToString/Convert.ToString
            //double num = 66.00430;
            //lblResultado.Text = num.ToString("#.00");

            //int num = 254;
            //lblResultado.Text = num.ToString("X"); //Imprimi o num no formato Hexadecimal
            //lblResultado.Text = num.ToString("D"); //Imprimi o num no formato Decimal
            //lblResultado.Text = num.ToString("X2"); //Hex minimo 2 digitos
            //lblResultado.Text = num.ToString("D2");  //Dec minimo 2 digitos
            //lblResultado.Text = num.ToString("C"); // Monetario

            //lblResultado.Text = Convert.ToString(num, 8); // Converte para OctaDecimal, 10 = Decimal e 16 = Hexadecimal
            #endregion

            #region Classe Math
            double pi = Math.PI;  //Pode usar o pi.ToString("#.2"); para entregar 2 casas decimais
            double E = Math.E;
            double seno = Math.Sin(3);
            double conseno = Math.Cos(3);
            double potencia = Math.Pow(2, 10);
            double raizQuadrada = Math.Sqrt(49);
            double aredonda = Math.Round(158.60);
            double inteiro = Math.Truncate(32.34523); //entrega só o número inteiro
            double floor = Math.Floor(52.99); //arredonda para baixo
            double ceil = Math.Ceiling(52.02); //arredonda para cima

            lblResultado.Text = ceil.ToString();
            #endregion
        }
    }
}
