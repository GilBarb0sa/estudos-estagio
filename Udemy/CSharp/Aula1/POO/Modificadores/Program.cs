using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            //t.nome = "";
            t.sobrenome = "";
            //t.Metodo1();
            t.Executar();
            
            Humano h = new Humano();
            h.idade = 19;
        }
    }
}
