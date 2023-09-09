namespace exe02lista
{
    public class SeguroDeVida : ITributavel
    {
        private const double _TAXA = 42.00;

        public double CalculaTributos()
        {
            return _TAXA;
        }
    }
}
