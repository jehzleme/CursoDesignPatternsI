namespace CursoDesignPatterns.Investimento
{
    public class Conservador : IInvestimento
    {
        public double Calcular(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
