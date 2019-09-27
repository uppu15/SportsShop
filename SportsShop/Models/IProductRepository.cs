using System.Linq;
namespace SportsShop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
