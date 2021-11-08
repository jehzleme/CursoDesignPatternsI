using CursoDesignPatterns.Investimento;

namespace CursoDesignPatterns.Formatacao
{
    public interface IFormato
    {
        public void Formatar(Requisicao requisicao, Conta conta);
    }
}