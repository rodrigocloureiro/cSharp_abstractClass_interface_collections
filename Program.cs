using exe02lista;

public class Program
{
    public static void Main(string[] args)
    {
        IList<Conta> contas = new List<Conta>();
        IList<SeguroDeVida> seguros = new List<SeguroDeVida>();

        for (int i = 0; i < 6; i++)
        {
            contas.Add(new ContaCorrente(Math.Floor(((double)new Random().Next(5000)) + 2000), $"Nome{Math.Floor((double)new Random().Next(100))}"));
            contas.Add(new ContaPoupanca(Math.Floor(((double)new Random().Next(5000)) + 2000), $"Nome{Math.Floor((double)new Random().Next(100))}"));
            seguros.Add(new SeguroDeVida($"Nome{Math.Floor((double)new Random().Next(100))}"));
        }

        List<ITributavel> tributaveis = new List<ITributavel>();
        //tributaveis.AddRange(contas.Where(conta => conta is ITributavel).Select(conta => conta as ITributavel).ToList());
        tributaveis.AddRange(contas.OfType<ITributavel>()); // retorna apenas os elementos que podem ser convetidos para o tipo
        tributaveis.AddRange(seguros);

        foreach (ITributavel clienteTributavel in tributaveis.OrderBy(tributavel => tributavel.CalculaTributos()).Reverse())
        {
            if (clienteTributavel is Conta conta)
            {
                Console.Write($"Nome: {conta.Nome} - Saldo: R$ {conta.ObterSaldo():F2} - ");
            }
            else if (clienteTributavel is SeguroDeVida seguro)
            {
                Console.Write($"Nome: {seguro.Nome} - ");
            }
            Console.Write($"Tributo: R$ {clienteTributavel.CalculaTributos():F2}\n");
        }

        Console.ReadKey();
    }
}
