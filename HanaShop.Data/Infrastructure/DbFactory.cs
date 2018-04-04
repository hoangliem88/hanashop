namespace HanaShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HanaShopDBContext dbContext;

        public HanaShopDBContext Init()
        {
            return dbContext ?? (dbContext = new HanaShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}