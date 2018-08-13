using EcommerceShop.Data.Infrastructure;
using EcommerceShop.Model.Models;

namespace EcommerceShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory) {
        }
    }
}