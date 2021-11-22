using CursoDesignPatterns.Investimento;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorio
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override string Cabecalho(Banco banco)
        {
            return $"{banco.Nome}\n{banco.Endereco}\n{banco.Telefone}\n";
        }

        protected override string Corpo(IEnumerable<Conta> contas)
        {
            foreach (var conta in contas)
            {
                return $"{conta.Titular} - {conta.Agencia} - {conta.Numero} - {conta.Saldo}\n";
            }
            return $"";
        }

        protected override string Rodape(Banco banco)
        {
            return $"{banco.Email}\n{DateTime.Now}";
        }
    }
}
