using System.Linq;

namespace CursoDesignPatterns.Imposto
{
    public class IHIT : TemplateImpostoCondicional
    {
        protected override bool UsarMaximaTaxacao(Orcamento orcamento)
        {
            return PossuiItensComMesmoNome(orcamento);
        }

        private bool PossuiItensComMesmoNome(Orcamento orcamento)
        {
            if (orcamento.Itens.GroupBy(i => i.Nome).Any(g => g.Count() > 1)) return true;

            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.0;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
    }
}
