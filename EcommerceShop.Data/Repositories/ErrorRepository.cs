using EcommerceShop.Data.Infrastructure;
using EcommerceShop.Model.Models;

namespace EcommerceShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory) {
        }
    }
}