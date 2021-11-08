using System;

namespace CursoDesignPatterns.Investimento
{
    class RealizadorInvestimento
    {
        public void RealizarInvestimento(Conta conta, IInvestimento investimento)
        {
            var retorno = investimento.Calcular(conta);

            var lucro = retorno * 0.75;

            conta.AdicionarLucroAoSaldo(lucro);

            Console.WriteLine($"Novo saldo: {conta.Saldo} ");
        }
    }
}
