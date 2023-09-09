namespace exe02lista
{
    public class SeguroDeVida : ITributavel
    {
        private const double _TAXA = 42.00;
        private string _nome;

        public SeguroDeVida(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public double CalculaTributos()
        {
            return _TAXA;
        }
    }
}
