using CursoDesignPatterns.Imposto;

namespace CursoDesignPatterns.Desconto
{
    public class DescontoValorMaiorQue : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Descontar(orcamento);
        }
    }
}