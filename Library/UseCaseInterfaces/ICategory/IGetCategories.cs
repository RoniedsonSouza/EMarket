using CoreBusiness;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.UseCaseInterfaces.ICategory
{ 
    public interface IGetCategories
    {
        IPagedList<Category> Execute(int pagina, int qtdPorPagina);
        IEnumerable<Category> ExecuteResult();
    }
}