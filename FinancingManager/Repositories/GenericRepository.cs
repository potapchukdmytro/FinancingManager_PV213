  using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingManager.Repositories
{
    public class GenericRepository<TEntity> 
        where TEntity : class, IBaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }
    }
}
