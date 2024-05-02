using System;

namespace Heranca
{
     abstract class Veiculo   //Classes abstratas não poder ser criados novos objetos
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar();

        public abstract void Parar();
        
    }
}
