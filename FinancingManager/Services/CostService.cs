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
            await costRepository.AddAsync(entity);
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
                    await costRepository.Remove(existingCost);
                }
                else
                {
                    Console.WriteLine("cost with " + costID + " not found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error while deleting cost: " + ex.Message);
            }
        }
        public async Task Edit(CostEntity editedCost)
        {
            try
            {
                var existingCost = await costRepository.GetByIdAsync(editedCost.Id);

                if (existingCost != null)
                {
                    await costRepository.Update(existingCost);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error while redacting cost: " + ex.Message);
            }
        }
        public List<CostEntity> GetAll()
        {
            try
            {
                return costRepository.Costs.ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
