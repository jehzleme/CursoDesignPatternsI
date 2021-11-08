﻿namespace CursoDesignPatterns.Imposto
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.0;
        }
    }
}