﻿  using FinancingManager.Entities;
using FluentValidation.Results;
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

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            try
            {
                var res = await _context.Set<TEntity>()
                    .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }
            
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }
    }
}
