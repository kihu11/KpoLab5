using System.Collections.Generic;
using Kpo.Business.Entities;

namespace Kpo.DataAccess.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        void SaveAll(List<Category> categories);
    }
}