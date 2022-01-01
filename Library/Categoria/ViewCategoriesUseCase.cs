using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.ICategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Categoria
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}
