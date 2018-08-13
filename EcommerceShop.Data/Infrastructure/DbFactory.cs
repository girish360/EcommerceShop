namespace EcommerceShop.Data.Infrastructure
{
    //khởi tạo đối tượng EcommerceShopDbContext để kết nối database dễ dàng
    public class DbFactory : Disposable, IDbFactory
    {
        private EcommerceShopDbContext dbContext;

        public EcommerceShopDbContext Init() {
            if (dbContext == null)
                dbContext = new EcommerceShopDbContext();

            return dbContext;

            //or use Null Coalescing Operator
            //return dbContext ?? (dbContext = new EcommerceShopDbContext());
        }

        protected override void DisposeCore() {
            if (dbContext != null) {
                dbContext.Dispose();
            }
        }
    }
}