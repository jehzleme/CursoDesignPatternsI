using CursoDesignPatterns.Investimento;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorio
{
    public interface IRelatorio
    {
        void GerarRelatorio(Banco banco, IEnumerable<Conta> contas); 
    }
}
