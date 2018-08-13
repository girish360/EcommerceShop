using EcommerceShop.Data.Infrastructure;
using EcommerceShop.Model.Models;

namespace EcommerceShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory) {
        }
    }
}