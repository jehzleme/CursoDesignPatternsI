using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Imposto
{
    public class IMA : Imposto
    {
        public IMA(Imposto outroImposto) : base(outroImposto) { }
        public IMA() : base() { }
        
        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalcularOutroImposto(orcamento);
        }
    }
}
