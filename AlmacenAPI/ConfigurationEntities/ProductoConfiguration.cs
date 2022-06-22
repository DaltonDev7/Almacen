using AlmacenAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlmacenAPI.ConfigurationEntities
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");  
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(20);
        }
    }
}
