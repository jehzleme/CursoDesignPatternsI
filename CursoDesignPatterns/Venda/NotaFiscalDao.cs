using System;

namespace CursoDesignPatterns.Venda
{
    public class NotaFiscalDao : IAcaoNotaGerada
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Simula BD.");
        }
    }
}