using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.ICategory
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}