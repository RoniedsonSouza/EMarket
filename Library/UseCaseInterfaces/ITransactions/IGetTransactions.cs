using CoreBusiness;
using System;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.ITransactions
{
    public interface IGetTransactions
    {
        IEnumerable<Transaction> Execute(string caixaNome, DateTime data, DateTime dataFinal);
    }
}