using System;

namespace CursoDesignPatterns.Investimento
{
    class Arrojado : IInvestimento
    {
        public double Calcular(Conta conta)
        {
            var chance = new Random().Next(101);

            if(chance < 20)
            {
                return conta.Saldo * 0.05;
            }

            else if(chance >=20 && chance <= 50)
            {
                return conta.Saldo * 0.03;
            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }
    }
}
