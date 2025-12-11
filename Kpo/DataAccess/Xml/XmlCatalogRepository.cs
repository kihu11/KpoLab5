using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Kpo.Business.Entities;
using Kpo.DataAccess.Interfaces;
using Kpo.DataAccess.Models;

namespace Kpo.DataAccess.Xml
{
    public class XmlCatalogRepository : ICategoryRepository
    {
        public List<Category> GetAll()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FoodCatalogDto));

            using FileStream fs = new FileStream(XmlPathProvider.CatalogPath, FileMode.Open);

            var dto = (FoodCatalogDto)serializer.Deserialize(fs);

            List<Category> categories = new();

            foreach (var catDto in dto.Categories)
                categories.Add(XmlProductMapper.Map(catDto));

            return categories;
        }

        public void SaveAll(List<Category> categories)
        {
            var dto = new FoodCatalogDto
            {
                Categories = new List<CategoryDto>()
            };

            foreach (var cat in categories)
            {
                dto.Categories.Add(new CategoryDto
                {
                    Name = cat.Name,
                    Products = cat.Products.ConvertAll(p => new ProductDto
                    {
                        Name = p.Name,
                        Proteins = p.Proteins,
                        Fats = p.Fats,
                        Carbs = p.Carbs,
                        CaloriesPer100g = p.CaloriesPer100g
                    })
                });
            }

            XmlSerializer serializer = new XmlSerializer(typeof(FoodCatalogDto));

            using FileStream fs = new FileStream(XmlPathProvider.CatalogPath, FileMode.Create);

            serializer.Serialize(fs, dto);
        }
    }
}