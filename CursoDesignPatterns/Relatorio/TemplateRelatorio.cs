using CursoDesignPatterns.Investimento;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorio
{
    public abstract class TemplateRelatorio : IRelatorio
    {
        public void GerarRelatorio(Banco banco, IEnumerable<Conta> contas)
        {
            Console.WriteLine(Cabecalho(banco));
            Console.WriteLine(Corpo(contas));
            Console.WriteLine(Rodape(banco));
        }

        protected abstract string Cabecalho(Banco banco);
        protected abstract string Corpo(IEnumerable<Conta> contas);
        protected abstract string Rodape(Banco banco);
    }
}