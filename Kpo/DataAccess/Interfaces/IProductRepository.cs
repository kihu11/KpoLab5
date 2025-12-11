using System.Collections.Generic;
using Kpo.Business.Entities;

namespace Kpo.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}