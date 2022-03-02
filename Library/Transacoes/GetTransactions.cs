using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using Library.UseCaseInterfaces.ITransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Transacoes
{
    public class GetTransactions : IGetTransactions
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTransactions(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(
            string caixaNome,
            DateTime data,
            DateTime dataFinal)
        {
            return transactionRepository.Search(caixaNome, data, dataFinal);
        }

        public IEnumerable<Transaction> ValorTotalTransacoes(DateTime data)
        {
            return transactionRepository.ValorTotal(data);
        }

        public IEnumerable<Transaction> ValorTotalTransacoesAnteriores(DateTime data)
        {
            return transactionRepository.ValorTotalAnterior(data);
        }
    }
}
