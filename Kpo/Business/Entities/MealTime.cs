using Kpo.Business.Base;
using System.Collections.Generic;
using System.Linq;

namespace Kpo.Business.Entities
{
    public class MealTime : BusinessObject
    {
        public string Name { get; set; }

        public Dictionary<Product, double> Products { get; set; } = new();

        public override void Validate()
        {
            ValidateLength(Name, 1, 50, "MealTime name");
        }

        public double TotalCalories =>
            Products.Sum(p => p.Key.CaloriesPer100g * p.Value / 100.0);

        public double TotalProteins =>
            Products.Sum(p => p.Key.Proteins * p.Value / 100.0);

        public double TotalFats =>
            Products.Sum(p => p.Key.Fats * p.Value / 100.0);

        public double TotalCarbs =>
            Products.Sum(p => p.Key.Carbs * p.Value / 100.0);
    }
}