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
    public class DashboardRepository : IDashboardRepository
    {
        private readonly MarketContext context;

        public DashboardRepository(MarketContext context)
        {
            this.context = context;
        }

        public IEnumerable<Transaction> ValorTotalMensal(DateTime data)
        {
            return context.Transactions.Where(x => x.DataTransacao.Month == data.Month);
        }
        public IEnumerable<Transaction> ValorTotalMensalAnterior(DateTime data)
        {
            data = data.AddMonths(-1);
            return context.Transactions.Where(x => x.DataTransacao.Date.ToString().Contains(data.ToString("yyyy-MM")));
        }
        public IEnumerable<Transaction> ValorTotalDiario(DateTime data)
        {
            return context.Transactions.Where(x => x.DataTransacao.Date.ToString().Contains(data.ToString("yyyy-MM-dd")));
        }
        public IEnumerable<Transaction> ValorTotalDiarioAnterior(DateTime data)
        {
            data = data.AddDays(-1);
            return context.Transactions.Where(x => x.DataTransacao.Date.ToString().Contains(data.ToString("yyyy-MM-dd")));
        }
    }
}
