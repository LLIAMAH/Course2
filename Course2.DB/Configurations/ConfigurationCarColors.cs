using Course2.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course2.DB.Configurations
{
    internal class ConfigurationCarColors : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color() { Id = 1, Name = "Black"},
                new Color() { Id = 2, Name = "Red" },
                new Color() { Id = 3, Name = "Orange" },
                new Color() { Id = 4, Name = "Blue" },
                new Color() { Id = 5, Name = "Green" },
                new Color() { Id = 6, Name = "Yellow" },
                new Color() { Id = 7, Name = "White" }
            );
        }
    }
}
