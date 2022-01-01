using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.ITransactions
{
    public interface IGetTodayTransactions
    {
        IEnumerable<Transaction> Execute(string caixaNome);
    }
}