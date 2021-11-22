namespace CursoDesignPatterns.Imposto
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.0 + CalcularOutroImposto(orcamento);
        }
    }
}