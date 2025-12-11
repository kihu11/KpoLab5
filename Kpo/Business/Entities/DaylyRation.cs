using Kpo.Business.Base;
using System.Collections.Generic;
using System.Linq;

namespace Kpo.Business.Entities
{
    public class DailyRation : BusinessObject
    {
        public User User { get; set; }
        public List<MealTime> MealTimes { get; set; } = new();

        public override void Validate()
        {
            User?.Validate();
            foreach (var meal in MealTimes)
                meal.Validate();
        }

        public double TotalCalories => MealTimes.Sum(m => m.TotalCalories);
        public double TotalProteins => MealTimes.Sum(m => m.TotalProteins);
        public double TotalFats => MealTimes.Sum(m => m.TotalFats);
        public double TotalCarbs => MealTimes.Sum(m => m.TotalCarbs);
    }
}