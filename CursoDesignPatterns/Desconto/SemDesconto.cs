﻿using CursoDesignPatterns.Imposto;

namespace CursoDesignPatterns.Desconto
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}
