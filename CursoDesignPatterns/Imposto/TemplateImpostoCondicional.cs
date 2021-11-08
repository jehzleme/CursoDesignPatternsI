namespace CursoDesignPatterns.Imposto
{
    public abstract class TemplateImpostoCondicional : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (UsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        protected abstract bool UsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
