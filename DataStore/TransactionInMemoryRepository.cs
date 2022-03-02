using CoreBusiness;
using Library.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {

        private List<Transaction> transactions;
        public TransactionInMemoryRepository()
        {
            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> Get(string caixaNome)
        {
            if (string.IsNullOrWhiteSpace(caixaNome))
                return transactions;
            else
                return transactions.Where(x => string.Equals(x.NomeCaixa, caixaNome, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Transaction> GetByDay(string caixaNome, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(caixaNome))
                return transactions.Where(x => x.DataTransacao.Date == date.Date);
            else
                return transactions.Where(x => 
                    string.Equals(x.NomeCaixa, caixaNome, StringComparison.OrdinalIgnoreCase) &&
                    x.DataTransacao.Date == date.Date);
        }

        public void Salvar(string nomeCaixa, int produtoId, string nomeProduto, double preco, int qtdAnterior, int qtdVendida)
        {
            int transactionId = 0;
            if (transactions != null && transactions.Count > 0)
            {
                int maxId = transactions.Max(X => X.TransactionId);
                transactionId = maxId + 1;

            } else {
                transactionId = 1;
            }

            transactions.Add(new Transaction
            {
                TransactionId = transactionId,
                ProdutoId = produtoId,
                NomeProduto = nomeProduto,
                DataTransacao = DateTime.Now,
                Preco = preco,
                QtdAnterior = qtdAnterior,
                QuantidadeVendida = qtdVendida,
                NomeCaixa = nomeCaixa
            });
        }

        public IEnumerable<Transaction> Search(string caixaNome, DateTime date, DateTime dateFinal)
        {
            if (string.IsNullOrWhiteSpace(caixaNome))
                return transactions.Where(x => x.DataTransacao >= date.Date && x.DataTransacao <= dateFinal.Date.AddDays(1).Date);
            else
                return transactions.Where(x =>
                    string.Equals(x.NomeCaixa, caixaNome, StringComparison.OrdinalIgnoreCase) &&
                    x.DataTransacao >= date.Date && x.DataTransacao <= dateFinal.Date.AddDays(1).Date);
        }

        public IEnumerable<Transaction> ValorTotal(DateTime data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> ValorTotalAnterior(DateTime data)
        {
            throw new NotImplementedException();
        }
    }
}
