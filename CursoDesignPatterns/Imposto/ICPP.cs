﻿namespace CursoDesignPatterns.Imposto
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }

        protected override bool UsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
