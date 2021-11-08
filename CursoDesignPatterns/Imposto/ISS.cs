namespace CursoDesignPatterns.Imposto
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}