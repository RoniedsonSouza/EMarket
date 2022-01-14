using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.ICategory;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Categoria.Queries
{
    public class GetCategories : IGetCategories
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategories(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IPagedList<Category> Execute(int pagina, int qtdPorPagina)
        {
            return categoryRepository.GetCategoriesAsync(pagina, qtdPorPagina);
        }
    }
}
