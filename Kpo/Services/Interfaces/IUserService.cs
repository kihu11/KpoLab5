using Kpo.Business.Entities;

namespace Kpo.Services.Interfaces
{
    public interface IUserService
    {
        double CalculateDailyCalorieRate(User user);
    }
}