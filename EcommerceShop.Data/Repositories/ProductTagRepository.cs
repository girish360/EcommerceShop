using EcommerceShop.Data.Infrastructure;
using EcommerceShop.Model.Models;

namespace EcommerceShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory) {
        }
    }
}