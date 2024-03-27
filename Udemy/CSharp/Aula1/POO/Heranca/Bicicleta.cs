using System;

namespace Heranca
{
     sealed class Bicicleta : Veiculo //Herda os atributos que estão em Veiculo  // Sealed, não deixa a classe ser herdada 
    {
        public void Pedalar()
        {
            Console.WriteLine("Pedalou");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta!");
        }

    }
}
