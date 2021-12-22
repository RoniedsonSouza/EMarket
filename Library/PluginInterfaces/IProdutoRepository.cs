using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.PluginInterfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetProdutos();
        void AddProduto(Produto produto);
    }
}
