using FinancingManager.Entities;

namespace FinancingManager.Initializer
{
    public static class Seeder
    {
        public static Task SeedAsync(AppDbContext context)
        {
            return Task.Run(() =>
            {
                if (!context.Users.Any())
                {
                    var user1 = new UserEntity
                    {
                        DateCreated = DateTime.UtcNow,
                        Email = "user1@gmail.com",
                        LastName = "surname1",
                        Name = "name1",
                        Password = "12345678",
                        UserName = "user1"
                    };

                    context.Add(user1);

                    var user2 = new UserEntity
                    {
                        DateCreated = DateTime.UtcNow,
                        Email = "user2@gmail.com",
                        LastName = "surname2",
                        Name = "name2",
                        Password = "12345678",
                        UserName = "user2"
                    };

                    context.Add(user2);

                    context.SaveChanges();
                }
            });
            
        }
    }
}
