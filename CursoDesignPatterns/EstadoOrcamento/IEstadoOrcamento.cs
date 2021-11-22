using CursoDesignPatterns.Imposto;

namespace CursoDesignPatterns.Estado
{
    public interface IEstadoOrcamento
    {
        void AplicarDescontoExtra(Orcamento orcamento);
        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento);
    }
}