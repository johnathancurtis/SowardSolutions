using System.Linq;

namespace ConsultingProducts.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
