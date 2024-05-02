using System;

namespace Heranca
{
     class Carro : Veiculo //Herda os atributos que estão em Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()  //Metodo ou Comportamento
        {
            Console.WriteLine("O carro ligou o motor"); ;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }

    }
}
