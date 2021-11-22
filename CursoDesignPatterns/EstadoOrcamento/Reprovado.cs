using System;

namespace CursoDesignPatterns.Estado
{
    public class Reprovado : IEstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra.");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi reprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
