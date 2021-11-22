using CursoDesignPatterns.Investimento;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.Filtro
{
    public class SaldoMinimo : Filtro
    {
        public SaldoMinimo(Filtro outroFiltro) : base(outroFiltro) { }
        public SaldoMinimo() : base() { }

        public override IEnumerable<Conta> Filtrar(IEnumerable<Conta> contas)
        {
            var contasFiltradas = contas.ToList();

            foreach (var conta in contas)
            {
                if (conta.Saldo < 100.0)
                    contasFiltradas.Remove(conta);
            }
            return FiltrarNovamente(contasFiltradas);
        }
    }
}