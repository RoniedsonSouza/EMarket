using CoreBusiness;
using Library.DataStorePluginInterfaces;
using Library.UseCaseInterfaces.ICategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Categoria.Commands
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public AddCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            categoryRepository.AddCategory(category);
        }
    }
}
