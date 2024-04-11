using Microsoft.EntityFrameworkCore;

namespace FIAP_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> MVC_Users { get; set; }
        public DbSet<Spell> MVC_Speels { get; set; }
    }
}
