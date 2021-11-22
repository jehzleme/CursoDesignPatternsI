using CursoDesignPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.Filtro
{
    public class AberturaMesCorrente : Filtro
    {
        public AberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro) { }
        public AberturaMesCorrente() : base() { }

        public override IEnumerable<Conta> Filtrar(IEnumerable<Conta> contas)
        {
            var contasFiltradas = contas.ToList();

            foreach (var conta in contas)
            {
                if (conta.Abertura.Month != DateTime.Now.Month || 
                    (conta.Abertura.Month != DateTime.Now.Month && conta.Abertura.Year != DateTime.Now.Year))
                    contasFiltradas.Remove(conta);
            }
            return FiltrarNovamente(contasFiltradas);
        }
    }
}