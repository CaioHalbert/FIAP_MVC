using FIAP_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FIAP_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
