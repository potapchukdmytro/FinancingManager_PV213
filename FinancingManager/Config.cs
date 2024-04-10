using AutoMapper;
using FinancingManager.Repositories;
using FinancingManager.Services;
using FinancingManager.Tools.Automapper;

namespace FinancingManager
{
    public class Config
    {
        public AppDbContext Context { get; init; }
        public UserRepository UserRepository { get; init; }
        public CostRepository CostRepository { get; init; }

        public UserService UserService { get; init; }
        public Mapper Mapper { get; init; }

        public Config()
        {
            Context = new AppDbContext();
            UserRepository = new UserRepository(Context);
            CostRepository = new CostRepository(Context);

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<UserProfile>();
            });

            Mapper = new Mapper(config);

            UserService = new UserService(UserRepository, Mapper);
        }
    }
}
