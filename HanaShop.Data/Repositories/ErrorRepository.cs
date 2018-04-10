using HanaShop.Data.Infrastructure;
using HanaShop.Model.Models;

namespace HanaShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErroRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErroRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}