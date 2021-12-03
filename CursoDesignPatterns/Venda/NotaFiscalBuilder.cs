using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Venda
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }
        
        private IList<ItemNota> _todosItens = new List<ItemNota>();

        public NotaFiscal Construir()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, _todosItens, Observacoes);
        }

        public NotaFiscalBuilder InserirEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder InserirCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder InserirObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder InserirData(DateTime? data)
        {
            Data = data ?? DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder InserirItem(ItemNota item)
        {
            _todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }
}