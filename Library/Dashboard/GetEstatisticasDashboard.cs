using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IDashboard;
using Library.UseCaseInterfaces.IProduto;
using Library.UseCaseInterfaces.ITransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Dashboard
{
    public class GetEstatisticasDashboard : IGetEstatisticasDashboard
    {
        private readonly IDashboardRepository dashboardRepository;

        public GetEstatisticasDashboard(IDashboardRepository dashboardRepository)
        {
            this.dashboardRepository = dashboardRepository;
        }

        public IEnumerable<Transaction> ValorTotalTransacoes(DateTime data)
        {
            return dashboardRepository.ValorTotalMensal(data);
        }

        public IEnumerable<Transaction> ValorTotalTransacoesAnteriores(DateTime data)
        {
            return dashboardRepository.ValorTotalMensalAnterior(data);
        }

        public IEnumerable<Transaction> ValorTotalDiario(DateTime data)
        {
            return dashboardRepository.ValorTotalDiario(data);
        }

        public IEnumerable<Transaction> ValorTotalDiarioAnteriores(DateTime data)
        {
            return dashboardRepository.ValorTotalDiarioAnterior(data);
        }
    }
}
