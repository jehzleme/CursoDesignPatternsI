using System;

namespace CursoDesignPatterns.Venda
{
    public class EnviadorSms : IAcaoNotaGerada
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("SMS.");
        }
    }
}