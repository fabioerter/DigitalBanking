using DigitalBanking.Domain.Entities;
using DigitalBanking.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace DigitalBanking.Infra.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
