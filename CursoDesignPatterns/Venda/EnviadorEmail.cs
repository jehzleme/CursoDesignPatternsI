using System;

namespace CursoDesignPatterns.Venda
{
    public class EnviadorEmail : IAcaoNotaGerada
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("E-mail enviado.");
        }
    }
}