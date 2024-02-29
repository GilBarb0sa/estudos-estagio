using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Utils
    {
        public static bool EhMaior(this int param, int secondParam)
        {
            return param >= secondParam;
        }

        public static int MultiplicaPor100(this int param)
        {
            return param * 100;
        }

        public static void PagarContaComCartao(this Conta conta)
        {
            Console.WriteLine("Pagando a conta com cartão");
        }
    }
}
