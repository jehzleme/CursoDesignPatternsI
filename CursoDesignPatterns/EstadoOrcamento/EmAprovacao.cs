using System;

namespace CursoDesignPatterns.Estado
{
    public class EmAprovacao : IEstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!orcamento.RecebeuDescontoExtra)
            {
                orcamento.Valor *= 0.95;
                orcamento.RecebeuDescontoExtra = true;
            }
            else
            {
                Console.WriteLine("Já recebeu desconto.");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado.");
        }
    }
}
