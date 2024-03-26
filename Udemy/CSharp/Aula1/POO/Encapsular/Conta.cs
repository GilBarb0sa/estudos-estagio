namespace Encapsular
{
    class Conta
    {
        private string _cliente;
        private double _saldo;
        private double _taxa = 10;

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "Gilberto" && value != "Logan")
                {
                    _cliente = "Visitante";
                    _saldo = 0;
                }
                else
                {
                    _cliente = value;
                    _saldo = 100;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            private set
            {
                _saldo = value; 
            }
        }

        public void Sacar(double valor)
        {
            valor += _taxa;
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
