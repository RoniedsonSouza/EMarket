using System;

namespace Library.UseCaseInterfaces.ITransactions
{
    public interface IHistoryTransactions
    {
        void Execute(string nomeCaixa, int produtoId, string nomeProduto, int qtd);
    }
}