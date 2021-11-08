using CursoDesignPatterns.Imposto;

namespace CursoDesignPatterns.Desconto
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        public double Descontar(Orcamento orcamento);
    }
}
