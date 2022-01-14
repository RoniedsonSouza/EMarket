using CoreBusiness;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.PluginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();

        void AddCategory(Category category);
        void UpdateCategory(Category category);

        Category GetCategoryById(int categoryId);
        void DeleteCategory(int categoryId);
        IPagedList<Category> GetCategoriesAsync(int pagina, int qtdPorPagina);

    }
}
