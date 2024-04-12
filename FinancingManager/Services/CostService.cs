using AutoMapper;
using FinancingManager.Entities;
using FinancingManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancingManager.Services
{
    public class CostService
    {
        private readonly CostRepository costRepository;
        private readonly Mapper mapper;

        public CostService(CostRepository costRepository, Mapper mapper)
        {
            this.costRepository = costRepository;
            this.mapper = mapper;
        }

        public async Task Add(CostEntity entity)
        {
            try
            {
                await costRepository.AddAsync(entity);
            }
            catch (Exception)
            {
            }   
        }

        public async Task<CostEntity?> GetByIdAsync(int id)
        {
            CostEntity? entity = await costRepository.GetByIdAsync(id);
            return entity;
        }

        public async Task Delete(int costID)
        {
            try
            {
                var existingCost = await costRepository.GetByIdAsync(costID);

                if (existingCost != null)
                {
                    await costRepository.RemoveAsync(existingCost);
                }
            }
            catch(Exception)
            {
            }
        }
        public async Task Edit(CostEntity editedCost)
        {
            try
            {
                var existingCost = await costRepository.GetByIdAsync(editedCost.Id);

                if (existingCost != null)
                {
                    await costRepository.UpdateAsync(existingCost);
                    
                }
            }
            catch (Exception)
            {
                
            }
        }
        public List<CostEntity> GetAll()
        {
            try
            {
                return costRepository.Costs.ToList();
            }
            catch(Exception)
            {
                return new List<CostEntity>();
            }
        }
    }
}
