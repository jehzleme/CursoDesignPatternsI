namespace CursoDesignPatterns.Investimento
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string NomeTitular { get; private set; }

        public Conta(double saldo, string nome)
        {
            Saldo = saldo;
            NomeTitular = nome;
        }

        public void AdicionarLucroAoSaldo(double lucroInvestimento)
        {
            Saldo += lucroInvestimento;
        }
    }
}
