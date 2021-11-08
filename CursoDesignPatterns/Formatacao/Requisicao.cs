namespace CursoDesignPatterns.Formatacao
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao()
        {
        }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }

    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }
}
