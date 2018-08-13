using System;

namespace EcommerceShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        EcommerceShopDbContext Init();
    }
}