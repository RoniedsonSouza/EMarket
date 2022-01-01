using CoreBusiness;
using Library.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MarketContext context;

        public CategoryRepository(MarketContext context)
        {
            this.context = context;
        }
        public void AddCategory(Category category)
        {
            context.Categorias.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = context.Categorias.Find(categoryId);
            if (category == null) return;

            context.Categorias.Remove(category);
            context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categorias.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return context.Categorias.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var cat = context.Categorias.Find(category.CategoryId);
            cat.Name = category.Name;
            cat.Description = category.Description;
            context.SaveChanges();
        }
    }
}
