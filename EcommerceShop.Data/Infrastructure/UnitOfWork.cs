namespace EcommerceShop.Data.Infrastructure
{
    // đóng vai trò như transaction
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private EcommerceShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory) {
            this.dbFactory = dbFactory;
        }

        public EcommerceShopDbContext DbContext {
            get {
                if (dbContext == null)
                    dbContext = dbFactory.Init();
                return dbContext;

                //return dbContext ?? (dbContext = dbFactory.Init());
            }
        }

        public void Commit() {
            DbContext.SaveChanges();
        }
    }
}