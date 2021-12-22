using CoreBusiness;

namespace Library.UseCaseInterfaces.ICategory
{
    public interface IGetCategoryById
    {
        Category Execute(int categoryId);
    }
}