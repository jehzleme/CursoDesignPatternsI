using System;

namespace CursoDesignPatterns.Imposto
{
    public class CalculadorImposto
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double calculo = imposto.Calcular(orcamento);
            Console.WriteLine(calculo);
        }
    }
}
