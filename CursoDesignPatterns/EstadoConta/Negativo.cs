using System;

namespace CursoDesignPatterns.EstadoConta
{
    public class Negativo : IEstadoConta
    {
        public void Sacar(Conta conta, double valor)
        {
            throw new Exception("Saldo está negativo, não pode aceitar saque.");
        }

        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0)
                conta.EstadoAtual = new Positivo();
        }
    }
}