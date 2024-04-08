using Microsoft.EntityFrameworkCore;

namespace FinancingManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=kjboiynw;Password=ChsIHmmhJgHwUAbmYqI_0BdG6A3T7-FJ;Host=tyke.db.elephantsql.com;Port=5432;Database=kjboiynw;");
        }
    }
}
