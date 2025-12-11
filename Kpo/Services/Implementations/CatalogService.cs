using System.Collections.Generic;
using System.Linq;
using Kpo.Business.Entities;
using Kpo.DataAccess.Interfaces;
using Kpo.Services.Interfaces;

namespace Kpo.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly ICategoryRepository _categoryRepo;

        public CatalogService(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepo.GetAll();
        }

        public void SaveCategories(List<Category> categories)
        {
            _categoryRepo.SaveAll(categories);
        }

        public void AddCategory(string name)
        {
            var categories = _categoryRepo.GetAll();

            if (categories.Any(c => c.Name == name))
                return;

            categories.Add(new Category { Name = name });

            _categoryRepo.SaveAll(categories);
        }

        public void RemoveCategory(string name)
        {
            var categories = _categoryRepo.GetAll()
                .Where(c => c.Name != name)
                .ToList();

            _categoryRepo.SaveAll(categories);
        }

        public void AddProduct(string categoryName, Product product)
        {
            var categories = _categoryRepo.GetAll();
            var category = categories.FirstOrDefault(c => c.Name == categoryName);

            if (category != null)
            {
                category.Products.Add(product);
                _categoryRepo.SaveAll(categories);
            }
        }

        public void RemoveProduct(string categoryName, string productName)
        {
            var categories = _categoryRepo.GetAll();
            var category = categories.FirstOrDefault(c => c.Name == categoryName);

            if (category != null)
            {
                category.Products.RemoveAll(p => p.Name == productName);
                _categoryRepo.SaveAll(categories);
            }
        }
    }
}

