using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Venda
{
    public class Multiplicador : IAcaoNotaGerada
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            Fator = fator;
        }

        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * Fator);
        }
    }
}
