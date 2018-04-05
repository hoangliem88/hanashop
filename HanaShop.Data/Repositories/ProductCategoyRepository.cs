using HanaShop.Data.Infrastructure;
using HanaShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace HanaShop.Data.Repositories
{
    public interface IProductCategoyRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoyRepository : RepositoryBase<ProductCategory>, IProductCategoyRepository
    {

        public ProductCategoyRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DBContext.ProductCategories.Where(m => m.Alias == alias);
        }
    }
}