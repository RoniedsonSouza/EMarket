using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using Library.UseCaseInterfaces.ITransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Produtos.Commands
{
    public class VenderProduto : IVenderProduto
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IHistoryTransactions historyTransactions;
        public VenderProduto(
            IProdutoRepository produtoRepository,
            IHistoryTransactions historyTransactions)
        {
            this.produtoRepository = produtoRepository;
            this.historyTransactions = historyTransactions;
        }
        public void Execute(string nomeCaixa, int produtoId, string nomeProduto, int QtdVendida)
        {
            var produto = produtoRepository.GetProdutoById(produtoId);
            if (produto == null) return;

            historyTransactions.Execute(nomeCaixa, produtoId, nomeProduto, QtdVendida);
            produto.Quantidade -= QtdVendida;
            produtoRepository.UpdateProduto(produto);
            
        }
    }
}
