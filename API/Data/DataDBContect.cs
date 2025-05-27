using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataDBContect : DbContext
    {
        public DataDBContect(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; } 
    }
}
