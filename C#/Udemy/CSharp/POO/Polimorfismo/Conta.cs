namespace Polimorfismo
{
    class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
           
        }

        public void Saldo()
        {
           
        }

        public void SolicitarEmprestimo()
        {

        }
    }

    interface IConta // Uma interface é abstract, por isso não é necessario colocar nos seus objetos e metodos.
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
