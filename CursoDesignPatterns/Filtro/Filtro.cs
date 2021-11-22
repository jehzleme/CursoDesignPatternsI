using CursoDesignPatterns.Investimento;
using System.Collections.Generic;

namespace CursoDesignPatterns.Filtro
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }
        public Filtro() { }

        public abstract IEnumerable<Conta> Filtrar(IEnumerable<Conta> contas);

        protected  IEnumerable<Conta> FiltrarNovamente(IEnumerable<Conta> contas)
        {
            return OutroFiltro == null ? contas : OutroFiltro.Filtrar(contas);
        }
    }
}