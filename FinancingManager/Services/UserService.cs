using AutoMapper;
using FinancingManager.Entities;
using FinancingManager.Models;
using FinancingManager.Repositories;
using FinancingManager.Validation;
using FluentValidation;

namespace FinancingManager.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;
        private readonly Mapper mapper;

        public UserService(UserRepository userRepository, Mapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public List<UserModel> GetUsers()
        {
            var entities = userRepository.GetAll().ToList(); 

            var models = mapper.Map<List<UserModel>>(entities);

            return models;
        }

        public async Task AddAsync(UserEntity entity)
        {
            await userRepository.AddAsync(entity);
        }

        public async Task<UserEntity?> GetByIdAsync(int id)
        {
            var entity = await userRepository.GetByIdAsync(id);
            return entity;
        }

        public async Task RemoveAsync(UserEntity entity)
        {
            var existingEntity = await GetByIdAsync(entity.Id);

            if (existingEntity != null)
            {
                await userRepository.Remove(entity);
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public async Task UpdateAsync(UserEntity entity)
        {
            var validator = new UserEntityValidator();
            var validationResult = await validator.ValidateAsync(entity);

            if (validationResult.IsValid)
            {
                var existingEntity = await GetByIdAsync(entity.Id);

                if (existingEntity != null)
                {
                    await userRepository.Update(entity);
                }
                else
                {
                    throw new Exception("User not found.");
                }
            }
            else
            {
                throw new ValidationException(validationResult.Errors);
            }
        }

    }
}
