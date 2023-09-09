namespace exe02lista
{
    public class Conta
    {
        private double _saldo;
        private string _nome;

        public Conta(double saldo, string nome)
        {
            _saldo = saldo;
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public void Sacar(double valor)
        {
            if (valor <= _saldo) _saldo -= valor;
            else Console.WriteLine("Saldo insuficiente..");
        }

        public void Depositar(double valor)
        {
            if (valor > 0) _saldo += valor;
            else Console.WriteLine("Valor inválido..");
        }

        public double ObterSaldo()
        {
            return _saldo;
        }
    }
}
