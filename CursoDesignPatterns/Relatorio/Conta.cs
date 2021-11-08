namespace CursoDesignPatterns.Relatorio
{
    public class Conta
    {
        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, string agencia, string numero, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }
    }
}