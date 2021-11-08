using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorio
{
    class RelatorioSimples : TemplateRelatorio
    {
        protected override string Cabecalho(Banco banco)
        {
            return $"{banco.Nome}\n";
        }

        protected override string Corpo(IEnumerable<Conta> contas)
        {
            foreach (var conta in contas)
            {
                return $"{conta.Titular} - {conta.Saldo}\n";
            }
            return $"";
        }

        protected override string Rodape(Banco banco)
        {
            return $"{banco.Telefone}";
        }
    }
}
