using Microsoft.EntityFrameworkCore; 
using DataBalkCSharp.Models;        
using DataBalkCSharp.Data;

namespace DataBalkCSharp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> Tasks { get; set; }
    }
}
