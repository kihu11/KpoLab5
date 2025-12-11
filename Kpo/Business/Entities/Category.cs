using Kpo.Business.Base;
using System.Collections.Generic;

namespace Kpo.Business.Entities
{
    public class Category : BusinessObject
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new();

        public override void Validate()
        {
            ValidateLength(Name, 1, 50, "Category name");
        }
    }
}