using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.PluginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(string caixaNome);
        public IEnumerable<Transaction> GetByDay(string caixaNome, DateTime date);
        public IEnumerable<Transaction> Search(string caixaNome, DateTime date, DateTime dateFinal);
        public void Salvar(string nomeCaixa, int produtoId, string nomeProduto, double preco,int qtdAnterior, int qtdVendida);
        public IEnumerable<Transaction> ValorTotal(DateTime data);
        public IEnumerable<Transaction> ValorTotalAnterior(DateTime data);
    }
}
