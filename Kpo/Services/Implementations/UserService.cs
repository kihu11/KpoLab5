using Kpo.Business.Entities;
using Kpo.Business.Services;
using Kpo.Services.Interfaces;

namespace Kpo.Services.Implementations
{
    public class UserService : IUserService
    {
        public double CalculateDailyCalorieRate(User user)
        {
            return CalorieCalculator.CalculateDailyCalorieRate(user);
        }
    }
}