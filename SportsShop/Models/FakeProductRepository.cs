using System.Linq;
using System.Collections.Generic;

namespace SportsShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Jehyun Signature Football", Price =25 },
            new Product { Name = "Surfboard", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
        }.AsQueryable<Product>();
    }
}
