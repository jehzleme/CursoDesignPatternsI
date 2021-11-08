using CursoDesignPatterns.Imposto;

namespace CursoDesignPatterns.Desconto
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (Existe("Lápis", orcamento) && Existe("Caneta", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return Proximo.Descontar(orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento) 
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
