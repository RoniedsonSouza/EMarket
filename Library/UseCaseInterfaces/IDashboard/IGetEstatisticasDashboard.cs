using CoreBusiness;
using System;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IDashboard
{
    public interface IGetEstatisticasDashboard
    {
        IEnumerable<Transaction> ValorTotalTransacoes(DateTime data);
        IEnumerable<Transaction> ValorTotalTransacoesAnteriores(DateTime data);
        IEnumerable<Transaction> ValorTotalDiario(DateTime data);
        IEnumerable<Transaction> ValorTotalDiarioAnteriores(DateTime data);
    }
}