using MyFirstApp.models;
using Microsoft.EntityFrameworkCore;


namespace MyFirstApp.context
{

    public class MyAppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=admin; database=dotNet; Integrated Security=true; Encrypt=False") ;
        }

        public DbSet<Student>? Students { get; set; }
    }
}
