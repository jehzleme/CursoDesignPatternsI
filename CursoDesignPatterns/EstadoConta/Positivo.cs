namespace CursoDesignPatterns.EstadoConta
{
    public class Positivo : IEstadoConta
    {
        public void Sacar(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0)
                conta.EstadoAtual = new Negativo();
        }

        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
    }
}
