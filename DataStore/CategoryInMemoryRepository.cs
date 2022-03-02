using CoreBusiness;
using Library.PluginInterfaces;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStore
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        public List<Category> categories;
        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category {CategoryId = 1, Name = "Beverage", Description = "Beverage"},
                new Category {CategoryId = 2, Name = "Bakery", Description = "Bakery"},
                new Category {CategoryId = 3, Name = "Meat", Description = "Met"}
            };
        }

        public void AddCategory(Category category)
        {
            if(categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            
            if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }

        public IPagedList<Category> GetCategoriesAsync(int? pagina, int qtdPorPagina)
        {
            throw new NotImplementedException();
        }
    }
}
