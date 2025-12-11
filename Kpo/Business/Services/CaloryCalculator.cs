using Kpo.Business.Entities;
using Kpo.Business.Enums;

namespace Kpo.Business.Services
{
    public static class CalorieCalculator
    {
        public static double CalculateDailyCalorieRate(User user)
        {
            double bmr = 447.593
                         + 9.247 * user.Weight
                         + 3.098 * user.Height
                         - 4.330 * user.Age;

            double arm = user.Activity switch
            {
                DailyActivity.Low => 1.2,
                DailyActivity.Normal => 1.375,
                DailyActivity.Average => 1.55,
                DailyActivity.High => 1.725,
                _ => 1.2
            };

            return bmr * arm;
        }
    }
}
