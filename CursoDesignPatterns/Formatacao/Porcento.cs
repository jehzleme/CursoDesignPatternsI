using CursoDesignPatterns.Investimento;
using System;

namespace CursoDesignPatterns.Formatacao
{
    public class Porcento : IFormato
    {
        public IFormato Proximo { get; private set; }

        public Porcento(IFormato proximoFormato)
        {
            Proximo = proximoFormato;
        }

        public Porcento()
        {
            Proximo = null;
        }

        public void Formatar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
                Console.WriteLine($"{conta.Saldo}%{conta.Titular}");

            else if (Proximo != null)
                Proximo.Formatar(requisicao, conta);

            else throw new Exception("Formato não encontrado.");
        }
    }
}