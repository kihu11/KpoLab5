using Kpo.Business.Entities;

namespace Kpo.Business.Services
{
    public class MealPlanner
    {
        public void AddProduct(MealTime mt, Product product, double weight = 100)
        {
            if (mt.Products.ContainsKey(product))
                mt.Products[product] += weight;
            else
                mt.Products[product] = weight;
        }

        public void RemoveProduct(MealTime mt, Product product)
        {
            if (mt.Products.ContainsKey(product))
                mt.Products.Remove(product);
        }

        public void ChangeWeight(MealTime mt, Product product, double newWeight)
        {
            if (mt.Products.ContainsKey(product))
                mt.Products[product] = newWeight;
        }
    }
}