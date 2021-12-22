using CoreBusiness;
using Library.DataStorePluginInterfaces;
using Library.UseCaseInterfaces.ICategory;

namespace Library.Categoria.Commands
{
    public class EditCategory : IEditCategory
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategory(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }
    }
}
