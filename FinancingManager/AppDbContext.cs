using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingManager
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=kjboiynw;Password=ChsIHmmhJgHwUAbmYqI_0BdG6A3T7-FJ;Host=tyke.db.elephantsql.com;Port=5432;Database=kjboiynw;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CostEntity> Costs { get; set; }
    }
}
