using Microsoft.EntityFrameworkCore;
using SQL_Connection.Models;

namespace SQL_Connection.DAL_data_access_layer_
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }   
}
