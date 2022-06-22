using AlmacenAPI.ConfigurationEntities;
using AlmacenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmacenAPI.Context
{
    public class AlmacenContext : DbContext
    {
        public AlmacenContext(DbContextOptions<AlmacenContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductoConfiguration());
        }
    }
}
