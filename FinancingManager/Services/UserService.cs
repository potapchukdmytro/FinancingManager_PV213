using AutoMapper;
using FinancingManager.Models;
using FinancingManager.Repositories;

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
    }
}
