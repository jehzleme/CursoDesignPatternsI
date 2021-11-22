namespace CursoDesignPatterns.Imposto
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
        public TemplateImpostoCondicional() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            if (UsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalcularOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalcularOutroImposto(orcamento);
        }

        protected abstract bool UsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
