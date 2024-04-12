using AutoMapper;
using FinancingManager.Entities;
using FinancingManager.Models;
using FinancingManager.Repositories;
using FinancingManager.Validation;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

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

        public async Task<UserModel?> GetByIdAsync(int id)
        {
            var entity = await userRepository.GetByIdAsync(id);
            var model = mapper.Map<UserModel>(entity);
            return model;
        }

        public async Task RemoveAsync(UserEntity entity)
        {
            var existingEntity = await GetByIdAsync(entity.Id);

            if (existingEntity != null)
            {
                await userRepository.RemoveAsync(entity);
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public async Task<UserModel?> Login(LogInModel model)
        {
            if(await UserExistAsync(model.Login))
            {
                var entity = await GetByLoginAsync(model.Login);

                if(entity.Password != model.Password)
                {
                    return null;
                }
                else
                {
                    return mapper.Map<UserModel>(entity);
                }
            }

            return null;
        }

        private async Task<bool> UserExistAsync(string login)
        {
            var user = await GetByLoginAsync(login);
            return user != null;
        } 

        private async Task<UserEntity?> GetByLoginAsync(string login)
        {
            var user = await userRepository.Users.FirstOrDefaultAsync(u => u.Email == login || u.UserName == login);
            return user;
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
                    await userRepository.UpdateAsync(entity);
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
