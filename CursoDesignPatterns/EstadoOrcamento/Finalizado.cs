using System;

namespace CursoDesignPatterns.Estado
{
    public class Finalizado : IEstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra.");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado.");
        }
    }
}
