namespace CursoDesignPatterns.Venda
{
    public class ItemNotaBuilder
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemNota Construir()
        {
            return new ItemNota(Descricao, Valor);
        }

        public ItemNotaBuilder InserirDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public ItemNotaBuilder InserirValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}