using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Drawing;

namespace Library.Produtos.Commands
{
    public class AddImagem : IAddImagem
    {
        private readonly IProdutoRepository produtoRepository;
        public AddImagem(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public void Execute(Produto produto, List<ImagensProdutos> imgs)
        {
            produtoRepository.AddImagem(produto, imgs);
        }
    }
}
