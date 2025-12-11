using Kpo.Business.Base;

namespace Kpo.Business.Entities
{
    public class Product : BusinessObject
    {
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbs { get; set; }
        public double CaloriesPer100g { get; set; }

        public override void Validate()
        {
            ValidateLength(Name, 1, 50, "Product name");
            ValidateRange(Proteins, 0, 100, "Proteins");
            ValidateRange(Fats, 0, 100, "Fats");
            ValidateRange(Carbs, 0, 100, "Carbs");
            ValidateRange(CaloriesPer100g, 0, 900, "Calories");
        }
    }
}