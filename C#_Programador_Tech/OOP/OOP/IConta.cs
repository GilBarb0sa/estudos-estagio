using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IConta //contratos que tem que ser assinados, estão abaixo
    {
        void Deposita(double valor); 
        bool Saca(double valor);
        void AdicionarLimite(double valor);
        double ConsultaSaldoDisponivel();
    }
}
