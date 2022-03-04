using CoreBusiness;
using Library.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext context;

        public TransactionRepository(MarketContext context)
        {
            this.context = context;
        }
        public IEnumerable<Transaction> Get(string caixaNome)
        {
            return context.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDay(string caixaNome, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(caixaNome))
                return context.Transactions.Where(x => x.DataTransacao.Date == date.Date);
            else
                return context.Transactions.Where(x =>
                    EF.Functions.Like(x.NomeCaixa, $"%{caixaNome}%") &&
                    x.DataTransacao.Date == date.Date);
        }

        public void Salvar(string nomeCaixa, int produtoId, string nomeProduto, double preco, int qtdAnterior, int qtdVendida)
        {
            var transaction = new Transaction
            {
                ProdutoId = produtoId,
                NomeProduto = nomeProduto,
                DataTransacao = DateTime.Now,
                Preco = preco,
                QtdAnterior = qtdAnterior,
                QuantidadeVendida = qtdVendida,
                NomeCaixa = nomeCaixa
            };
            context.Transactions.Add(transaction);
            context.SaveChanges();
        }

        public IEnumerable<Transaction> Search(string caixaNome, DateTime date, DateTime dateFinal)
        {
            if (string.IsNullOrWhiteSpace(caixaNome))
                return context.Transactions.Where(x => x.DataTransacao >= date.Date && x.DataTransacao <= dateFinal.Date.AddDays(1).Date);
            else
                return context.Transactions.Where(x =>
                    EF.Functions.Like(x.NomeCaixa, $"%{caixaNome}%") &&
                    x.DataTransacao >= date.Date && x.DataTransacao <= dateFinal.Date.AddDays(1).Date);
        }
    }
}
