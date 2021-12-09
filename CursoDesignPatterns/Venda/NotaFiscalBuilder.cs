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
        
        private ICollection<ItemNota> _todosItens = new List<ItemNota>();

        private ICollection<IAcaoNotaGerada> _todasAcoes;

        public NotaFiscalBuilder(ICollection<IAcaoNotaGerada> todasAcoes)
        {
            _todasAcoes = todasAcoes;
        }

        public NotaFiscal Construir()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, _todosItens, Observacoes);
            
            foreach (var acao in _todasAcoes)
            {
                acao.Executar(nf);
            }
            return nf;
        }

        public void AdicionarAcao(IAcaoNotaGerada acao)
        {
            _todasAcoes.Add(acao);
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