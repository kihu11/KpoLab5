using System.Collections.Generic;
using System.Linq;
using Kpo.Business.Entities;
using Kpo.Services.Interfaces;
using Kpo.Business.Services;

namespace Kpo.Services.Implementations
{
    public class MealService : IMealService
    {
        public DailyRation CreateDailyRation(User user)
        {
            return new DailyRation
            {
                User = user,
                MealTimes = new List<MealTime>()
                {
                    new MealTime { Name = "Breakfast" },
                    new MealTime { Name = "Lunch" },
                    new MealTime { Name = "Dinner" }
                }
            };
        }

        public void AddMeal(DailyRation ration, MealTime meal)
        {
            ration.MealTimes.Add(meal);
        }

        public void RemoveMeal(DailyRation ration, string mealName)
        {
            ration.MealTimes.RemoveAll(m => m.Name == mealName);
        }

        public void AddProduct(MealTime meal, Product product, double weight)
        {
            if (meal.Products.ContainsKey(product))
                meal.Products[product] += weight;
            else
                meal.Products[product] = weight;
        }

        public void ChangeWeight(MealTime meal, Product product, double weight)
        {
            if (meal.Products.ContainsKey(product))
                meal.Products[product] = weight;
        }

        public void RemoveProduct(MealTime meal, Product product)
        {
            if (meal.Products.ContainsKey(product))
                meal.Products.Remove(product);
        }

        public double GetTotalCalories(DailyRation ration)
        {
            return ration.TotalCalories;
        }
    }
}