using CursoDesignPatterns.Desconto;
using CursoDesignPatterns.EstadoConta;
using CursoDesignPatterns.Filtro;
using CursoDesignPatterns.Formatacao;
using CursoDesignPatterns.Imposto;
using CursoDesignPatterns.Investimento;
using CursoDesignPatterns.Relatorio;
using CursoDesignPatterns.Venda;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //var conta = new Conta(500.0, "Jéssica Leme");

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


            ////Relatorio
            //var banco = new Banco("Banco Cervejeiro", "Rua Brahma, 4653 - Parque da Cerveja", "3524-8216", "banco@bcervejeiro.com.br");
            //var contas = new List<Conta> {new Conta("Jéssica Ambrust", "0546", "45.648-4", 1000.0),
            //                                        new Conta("Lucas Ambrust", "0456", "54.824-2", 500.0)};

            //IRelatorio relatorioSimples = new RelatorioSimples();
            //IRelatorio relatorioComplexo = new RelatorioComplexo();

            //Console.WriteLine("------------ Relatório Simples\n");
            //relatorioSimples.GerarRelatorio(banco, contas);
            //Console.WriteLine("------------ Relatório Complexo\n");
            //relatorioComplexo.GerarRelatorio(banco, contas);


            ////DecoratorImposto
            //Imposto.Imposto impostos = new ICPP(new IKCV());

            //Orcamento orcamento = new Orcamento(500);

            //double valor = impostos.Calcular(orcamento);

            //Console.WriteLine(valor);


            ////Filtro
            //var contas = new List<Conta> { new Conta("Jehz", "165", "123456", 99, new DateTime(2021, 05, 10)),
            //                                         new Conta("Jehz", "165", "123456", 99, new DateTime(2021, 11, 10)),
            //                                         new Conta("Jéssica", "165", "123456", 501000, new DateTime(2021, 05, 10)), 
            //                                         new Conta("Jéssica", "165", "123456", 501000, new DateTime(2021, 11, 10)) };

            //Filtro.Filtro filtro = new AberturaMesCorrente();

            //var contasFiltradas = filtro.Filtrar(contas);

            //foreach (var contaFiltrada in contasFiltradas)
            //{
            //    Console.WriteLine($"{contaFiltrada.Titular}, {contaFiltrada.Saldo}, {contaFiltrada.Abertura}");
            //}

            ////StateOrcamento
            //Orcamento reforma = new Orcamento(500);

            //Console.WriteLine(reforma.Valor);

            //reforma.AplicarDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Aprovar();

            //reforma.AplicarDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Finalizar();

            ////StateConta
            //Conta conta = new Conta("Jehz", "165", "123456", 100, new DateTime(2021, 05, 10));


            //Console.WriteLine($"Saldo inicial: {conta.Saldo}");

            //conta.Depositar(100);
            //Console.WriteLine($"Saldo após deposito em saldo positivo: {conta.Saldo}");

            //conta.Sacar(200);
            //Console.WriteLine($"Saldo após saque em saldo positivo: {conta.Saldo}");

            //conta.Depositar(100);
            //Console.WriteLine($"Saldo após deposito em saldo negativo: { conta.Saldo}");

            //conta.Sacar(200);
            //Console.WriteLine($"Saldo após saque em saldo positivo: {conta.Saldo}");

            //conta.Sacar(200);
            //Console.WriteLine($"Saldo após saque em saldo negativo: {conta.Saldo}"); // esperado exception

            //Venda
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.InserirEmpresa("Empresa Tal")
            .InserirCnpj("23.456.789/0001-12")
            .InserirItem(new ItemNota("Item1", 10.5))
            .InserirItem(new ItemNota("Item2", 100.5))
            .InserirData(null)
            .InserirObservacoes("uma obs");

            var nf = criador.Construir();

            Console.WriteLine(nf.Impostos);
            Console.WriteLine(nf.ValorBruto);

            Console.ReadKey();
        }
    }
}