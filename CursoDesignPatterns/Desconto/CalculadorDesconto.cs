using CursoDesignPatterns.Imposto;

namespace CursoDesignPatterns.Desconto
{
    public class CalculadorDesconto
    {
        public double Calcular(Orcamento orcamento)
        {
            IDesconto d1 = new Desconto5Itens();
            IDesconto d2 = new DescontoValorMaiorQue();
            IDesconto d3 = new DescontoVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Descontar(orcamento);
        }
    }
}
