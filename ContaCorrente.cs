namespace exe02lista
{
    public class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(double saldo, string nome) : base(saldo, nome) { }

        public double CalculaTributos()
        {
            return ObterSaldo() * 0.01;
        }
    }
}
