using Course2.DB.Configurations;
using Course2.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Course2.DB
{
    public class AppDbCtx : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<Model> Models { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                    "Data Source=.\\sqlexpress;Initial Catalog=ExperimentsDB;" +
                    "Integrated Security=True;Encrypt=false;MultipleActiveResultSets=True")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .ToTable(c => c.IsTemporal());

            modelBuilder.ApplyConfiguration(new ConfigurationCarColors());
        }
    }
}
