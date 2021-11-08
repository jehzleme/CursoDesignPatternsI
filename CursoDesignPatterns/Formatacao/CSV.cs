using CursoDesignPatterns.Investimento;
using System;

namespace CursoDesignPatterns.Formatacao
{
    public class CSV : IFormato
    {
        public IFormato Proximo { get; private set; }

        public CSV(IFormato proximoFormato)
        {
            Proximo = proximoFormato;
        }

        public void Formatar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
                Console.WriteLine($"{conta.Saldo};{conta.NomeTitular}");
            
            Proximo.Formatar(requisicao, conta);
        }
    }
}