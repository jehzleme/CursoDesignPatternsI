using System.Collections.Generic;
using CursoDesignPatterns.Estado;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public IEstadoOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public bool RecebeuDescontoExtra { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
            RecebeuDescontoExtra = false;
        }

        public void AplicarDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Valor;
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }
        
        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }
        
        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
        }
    }
}
