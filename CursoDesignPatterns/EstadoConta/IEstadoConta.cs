namespace CursoDesignPatterns.EstadoConta
{
    public interface IEstadoConta
    {
        void Sacar(Conta conta, double saque);
        void Depositar(Conta conta, double deposito);
    }
}