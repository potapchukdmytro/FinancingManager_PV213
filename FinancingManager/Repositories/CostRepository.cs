using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingManager.Repositories
{
    public class CostRepository : GenericRepository<CostEntity>
    {
        public CostRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<CostEntity> Costs {
            get
            {
                return GetAll().Include(x => x.User);
            }
        }
    }
}
