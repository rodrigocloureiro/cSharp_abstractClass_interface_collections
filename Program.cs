using exe02lista;

public class Program
{
    public static void Main(string[] args)
    {
        IList<Conta> contas = new List<Conta>();
        IList<SeguroDeVida> seguros = new List<SeguroDeVida>();

        for (int i = 0; i < 6; i++)
        {
            contas.Add(new ContaCorrente(Math.Floor((double)new Random().Next() * 3000 + 2000), $"Nome{Math.Floor((double)new Random().Next() * 100)}"));
            contas.Add(new ContaPoupanca(Math.Floor((double)new Random().Next() * 3000 + 2000), $"Nome{Math.Floor((double)new Random().Next() * 100)}"));
            seguros.Add(new SeguroDeVida());
        }
    }
}
