using DigitalBanking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalBanking.Infra.Data.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("PK_Funcionario");

            builder.Property(e => e.DataNascimento).HasColumnType("datetime");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.FkEstado).HasColumnName("FK_Estado");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Salario).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Estado)
                .WithMany(p => p.Funcionario)
                .HasForeignKey(d => d.FkEstado)
                .HasConstraintName("FK_Funcionario_Estado");
        }
    }
}
