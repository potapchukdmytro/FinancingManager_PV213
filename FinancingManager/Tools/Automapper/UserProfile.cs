using AutoMapper;
using FinancingManager.Entities;
using FinancingManager.Models;

namespace FinancingManager.Tools.Automapper
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<UserEntity, UserModel>();
        }
    }
}
