using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta 
    {
        public double Saldo { get; set; } // Get : Diz que pode ser acessado, pode ser buscado - Set : Pode adicionar um valor para este saldo
        public double Limite { get; set; }
        public int Numero { get; set; }
    }
}
