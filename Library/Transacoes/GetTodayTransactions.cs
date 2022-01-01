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
    public class GetTodayTransactions : IGetTodayTransactions
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTodayTransactions(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(string caixaNome)
        {
            return transactionRepository.GetByDay(caixaNome, DateTime.Now);
        }
    }
}
