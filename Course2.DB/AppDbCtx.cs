using Course2.DB.Configurations;
using Course2.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Course2.DB
{
    public class AppDbCtx : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.\\sqlexpress;Initial Catalog=ExperimentsDB;" +
                "Integrated Security=True;Encrypt=false;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigurationCarColors());

        }
    }
}
