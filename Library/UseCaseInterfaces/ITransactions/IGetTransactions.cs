using CoreBusiness;
using System;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.ITransactions
{
    public interface IGetTransactions
    {
        IEnumerable<Transaction> Execute(string caixaNome, DateTime data, DateTime dataFinal);
        IEnumerable<Transaction> ValorTotalTransacoes(DateTime data);
        IEnumerable<Transaction> ValorTotalTransacoesAnteriores(DateTime data);
    }
}