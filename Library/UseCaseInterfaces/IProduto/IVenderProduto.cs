namespace Library.UseCaseInterfaces.IProduto
{
    public interface IVenderProduto
    {
        void Execute(string nomeCaixa, int produtoId, string nomeProduto, int QtdVendida);
    }
}