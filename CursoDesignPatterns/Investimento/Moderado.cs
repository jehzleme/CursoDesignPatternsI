using System;

namespace CursoDesignPatterns.Investimento
{
    public class Moderado : IInvestimento
    {
        public double Calcular(Conta conta)
        {
            bool chance = new Random().Next(101) > 50;

            if (chance)
            {
                return conta.Saldo * 0.025;
            }
            else
                return conta.Saldo * 0.007;
        }
    }
}
