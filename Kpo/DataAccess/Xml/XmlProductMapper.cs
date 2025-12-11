using Kpo.Business.Entities;
using Kpo.DataAccess.Models;

namespace Kpo.DataAccess.Xml
{
    public static class XmlProductMapper
    {
        public static Product Map(ProductDto dto)
        {
            return new Product
            {
                Name = dto.Name,
                Proteins = dto.Proteins,
                Fats = dto.Fats,
                Carbs = dto.Carbs,
                CaloriesPer100g = dto.CaloriesPer100g
            };
        }

        public static Category Map(CategoryDto dto)
        {
            var category = new Category
            {
                Name = dto.Name
            };

            foreach (var p in dto.Products)
                category.Products.Add(Map(p));

            return category;
        }
    }
}