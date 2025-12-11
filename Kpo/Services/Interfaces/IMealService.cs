using System.Collections.Generic;
using Kpo.Business.Entities;

namespace Kpo.Services.Interfaces
{
    public interface IMealService
    {
        DailyRation CreateDailyRation(User user);

        void AddMeal(DailyRation ration, MealTime meal);
        void RemoveMeal(DailyRation ration, string mealName);

        void AddProduct(MealTime meal, Product product, double weight);
        void ChangeWeight(MealTime meal, Product product, double weight);
        void RemoveProduct(MealTime meal, Product product);

        double GetTotalCalories(DailyRation ration);
    }
}