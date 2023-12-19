using Microsoft.EntityFrameworkCore;
using MyProject.Data.Model;

namespace MyProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Credit> Credits { get; set; }
    }
}
