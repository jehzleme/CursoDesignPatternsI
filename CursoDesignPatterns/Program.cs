using CursoDesignPatterns.Desconto;
using CursoDesignPatterns.Formatacao;
using CursoDesignPatterns.Imposto;
using CursoDesignPatterns.Investimento;
using CursoDesignPatterns.Relatorio;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Imposto
            //IImposto iss = new ISS();
            //IImposto icms = new ICMS();
            //IImposto iccc = new ICCC();

            //var orcamento = new Orcamento(500.0);

            //var calculadorImposto = new CalculadorImposto();

            //calculadorImposto.RealizarCalculo(orcamento, iss);
            //calculadorImposto.RealizarCalculo(orcamento, icms);
            //calculadorImposto.RealizarCalculo(orcamento, iccc);

            //Console.WriteLine(iccc.Calcular(orcamento));

            ////Investimento
            //IInvestimento conservador = new Conservador();
            //IInvestimento moderado = new Moderado();
            //IInvestimento arrojado = new Arrojado();

            //var saldo = new Conta(1000.0);

            //var realizadorInvestimento = new RealizadorInvestimento();

            //realizadorInvestimento.RealizarInvestimento(saldo, conservador);
            //realizadorInvestimento.RealizarInvestimento(saldo, moderado);
            //realizadorInvestimento.RealizarInvestimento(saldo, arrojado);


            ////Desconto
            //var calculador = new CalculadorDesconto();
            //var orcamento = new Orcamento(0);
            //orcamento.AdicionaItem(new Item("Caneta", 20));
            //orcamento.AdicionaItem(new Item("Lápis", 20));
            //orcamento.AdicionaItem(new Item("Lapiseira", 20));

            //var desconto = calculador.Calcular(orcamento);
            //Console.WriteLine(desconto);


            ////Formatação
            //var processador = new ProcessadorRequisicao();
            //var conta = new Investimento.Conta(500.0, "Jéssica Leme");

            //var requisicaoXML = new Requisicao(Formato.XML);
            //var requisicaoCSV = new Requisicao(Formato.CSV);
            //var requisicaoPorcento = new Requisicao(Formato.PORCENTO);

            //IFormato formato = new XML(new CSV(new Porcento()));

            //processador.Processar(requisicaoXML, conta);


            ////TemplateImposto
            //IImposto icpp = new ICPP();
            //IImposto ikcv = new IKCV();
            //IImposto ihit = new IHIT();

            //var orcamento = new Orcamento(0);

            //orcamento.AdicionaItem(new Item("Caneta", 20));
            //orcamento.AdicionaItem(new Item("Lápis", 20));
            //orcamento.AdicionaItem(new Item("Lapiseira", 20));

            //var calculadorImposto = new CalculadorImposto();

            //calculadorImposto.RealizarCalculo(orcamento, icpp);
            //calculadorImposto.RealizarCalculo(orcamento, ikcv);
            //calculadorImposto.RealizarCalculo(orcamento, ihit);


            //Relatorio
            var banco = new Banco("Banco Cervejeiro", "Rua Brahma, 4653 - Parque da Cerveja", "3524-8216", "banco@bcervejeiro.com.br");
            var contas = new List<Relatorio.Conta> {new Relatorio.Conta("Jéssica Ambrust", "0546", "45.648-4", 1000.0),
                                                    new Relatorio.Conta("Lucas Ambrust", "0456", "54.824-2", 500.0)};

            IRelatorio relatorioSimples = new RelatorioSimples();
            IRelatorio relatorioComplexo = new RelatorioComplexo();

            Console.WriteLine("------------ Relatório Simples\n");
            relatorioSimples.GerarRelatorio(banco, contas);
            Console.WriteLine("------------ Relatório Complexo\n");
            relatorioComplexo.GerarRelatorio(banco, contas);

            Console.ReadKey();
        }
    }
}