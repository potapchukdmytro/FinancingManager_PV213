using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingManager.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<UserEntity> Users
        {
            get
            {
                return GetAll().Include(x => x.Costs);
            }
        }
    }
}
