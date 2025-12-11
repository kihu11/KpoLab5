using Kpo.DataAccess.Interfaces;
using Kpo.Services.Interfaces;
using Kpo.Services.Implementations;

namespace Kpo.Services
{
    public class ServiceFacade
    {
        public ICatalogService CatalogService { get; }
        public IMealService MealService { get; }
        public IUserService UserService { get; }

        public ServiceFacade(ICategoryRepository categoryRepository)
        {
            CatalogService = new CatalogService(categoryRepository);
            MealService = new MealService();
            UserService = new UserService();
        }
    }

}