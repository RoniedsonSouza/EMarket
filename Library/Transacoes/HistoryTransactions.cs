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
    public class HistoryTransactions : IHistoryTransactions
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProdutoById getProdutoById;

        public HistoryTransactions(
            ITransactionRepository transactionRepository,
            IGetProdutoById getProdutoById)
        {
            this.transactionRepository = transactionRepository;
            this.getProdutoById = getProdutoById;
        }
        public void Execute(string nomeCaixa, int produtoId, string nomeProduto, int qtd)
        {
            var product = getProdutoById.Execute(produtoId);
            transactionRepository.Salvar(nomeCaixa, produtoId, nomeProduto, product.Preco.Value, product.Quantidade.Value, qtd);
        }
    }
}
