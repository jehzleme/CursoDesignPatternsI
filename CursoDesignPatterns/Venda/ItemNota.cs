namespace CursoDesignPatterns.Venda
{
    public class ItemNota
    {
        public string  Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemNota(string nome, double valor)
        {
            Descricao = nome;
            Valor = valor;
        }
    }
}