using System;

namespace CursoDesignPatterns.Estado
{
    public class Aprovado : IEstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!orcamento.RecebeuDescontoExtra)
            {
                orcamento.Valor *= 0.98;
                orcamento.RecebeuDescontoExtra = true;
            }
            else
            {
                Console.WriteLine("Já recebeu desconto.");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi aprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi aprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
