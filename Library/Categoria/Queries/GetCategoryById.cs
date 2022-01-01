using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.ICategory;

namespace Library.Categoria.Queries
{
    public class GetCategoryById : IGetCategoryById
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryById(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Execute(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }
    }
}
