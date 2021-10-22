using Eureka.Domain.Model;
using Eureka.Domain.Repository;
using Eureka.Infra.Data.Context;

namespace Eureka.Infra.Data.Repository
{
    public class CrudRepository : Repository<Crud>, ICrudRepository
    {
        public CrudRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
