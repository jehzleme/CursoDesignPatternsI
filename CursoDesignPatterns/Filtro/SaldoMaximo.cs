using CursoDesignPatterns.Investimento;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.Filtro
{
    public class SaldoMaximo : Filtro
    {
        public SaldoMaximo(Filtro outroFiltro) : base(outroFiltro) { }
        public SaldoMaximo() : base() { } 

        public override IEnumerable<Conta> Filtrar(IEnumerable<Conta> contas)
        {
            var contasFiltradas = contas.ToList();

            foreach (var conta in contas)
            {
                if (conta.Saldo > 500000.0)
                    contasFiltradas.Remove(conta);
            }
            return FiltrarNovamente(contasFiltradas);
        }
    }
}