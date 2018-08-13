using EcommerceShop.Data.Infrastructure;
using EcommerceShop.Model.Models;

namespace EcommerceShop.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig>
    {
    }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory) {
        }
    }
}