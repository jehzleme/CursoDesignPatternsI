using CursoDesignPatterns.Investimento;
using System;

namespace CursoDesignPatterns.Formatacao
{
    public class XML : IFormato
    {
        public IFormato Proximo { get; private set; }

        public XML(IFormato proximoFormato)
        {
            Proximo = proximoFormato;
        }

        public void Formatar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
                Console.WriteLine($"<Conta>\n<Saldo>{conta.Saldo}</Saldo>\n<NomeTitular>{conta.NomeTitular}</NomeTitular>\n</Conta>");

            Proximo.Formatar(requisicao, conta);
        }
    }
}