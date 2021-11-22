using CursoDesignPatterns.EstadoConta;
using System;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public IEstadoConta EstadoAtual { get; set; }
        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public DateTime Abertura { get; private set; }
        public double Saldo { get; set; }

        public Conta(string titular, string agencia, string numero, double saldo, DateTime abertura)
        {
            Estado(saldo);
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Abertura = abertura;
            Saldo = saldo;
        }

        private void Estado(double saldo)
        {
            if (saldo >= 0)
                EstadoAtual = new Positivo();
            EstadoAtual = new Negativo();
        }

        public void AdicionarLucroAoSaldo(double lucroInvestimento)
        {
            Saldo += lucroInvestimento;
        }

        public void Sacar(double saque)
        {
            EstadoAtual.Sacar(this, saque);
        }

        public void Depositar(double deposito)
        {
            EstadoAtual.Depositar(this, deposito);
        }
    }
}