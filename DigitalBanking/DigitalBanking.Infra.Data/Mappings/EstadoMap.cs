using DigitalBanking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalBanking.Infra.Data.Mappings
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("PK_Estado");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Sigla)
                .IsRequired()
                .HasMaxLength(2);
        }
    }
}
