using CoreBusiness;
using System;
using System.Collections.Generic;

namespace Library.PluginInterfaces
{
    public interface IDashboardRepository
    {
        IEnumerable<Transaction> ValorTotalMensal(DateTime data);
        IEnumerable<Transaction> ValorTotalMensalAnterior(DateTime data);
        IEnumerable<Transaction> ValorTotalDiario(DateTime data);
        IEnumerable<Transaction> ValorTotalDiarioAnterior(DateTime data);
    }
}