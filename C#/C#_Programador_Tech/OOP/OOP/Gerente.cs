using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Gerente : Funcionario //Herda
    {
        public override void Reajustar() //override - vamos sobrepor a classe funcionario, reescrevendo
        {
            this.Salario += 1000;
        }
    }
}
