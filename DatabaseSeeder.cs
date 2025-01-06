using System.Security.Cryptography;
using DataBalkCSharp.Data;
using DataBalkCSharp.Models;

namespace DataBalkCSharp
{
    public static class DatabaseSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var rng = RandomNumberGenerator.Create();

                var key1 = new byte[32];
                rng.GetBytes(key1);

                var key2 = new byte[32];
                rng.GetBytes(key2);

                context.Users.AddRange(
                    new User
                    {
                        Username = "JohnDoe",
                        Email = "john@databalk.com",
                        Password = "password123",
                        JwtKey = Convert.ToBase64String(key1) 
                    },
                    new User
                    {
                        Username = "JaneDoe",
                        Email = "jane@databalk.com",
                        Password = "securepassword",
                        JwtKey = Convert.ToBase64String(key2) 
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
