using System.Collections.Generic;
using Kpo.Business.Entities;

namespace Kpo.Services.Interfaces
{
    public interface ICatalogService
    {
        List<Category> GetAllCategories();
        void SaveCategories(List<Category> categories);

        void AddCategory(string name);
        void RemoveCategory(string name);

        void AddProduct(string categoryName, Product product);
        void RemoveProduct(string categoryName, string productName);
    }
}