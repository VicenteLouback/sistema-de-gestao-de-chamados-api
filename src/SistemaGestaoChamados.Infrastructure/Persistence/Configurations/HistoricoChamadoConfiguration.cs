using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;


namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations
{
    public class HistoricoChamadoConfiguration : IEntityTypeConfiguration<HistoricoChamado>
    {
        public void Configure(EntityTypeBuilder<HistoricoChamado> builder)
        {
            builder.ToTable("HistoricoChamado");

            builder.HasKey(h => h.Id);

            builder.Property(h => h.CampoAlterado)
                .HasColumnName("CampoAlterado")
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(h => h.ValorAnterior)
                .HasColumnName("ValorAnterior")
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(h => h.ValorNovo)
                .HasColumnName("ValorNovo")
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(h => h.DataAlteracao)
                .HasColumnName("DataAlteracao")
                .IsRequired();

            builder.Property(h => h.ChamadoId)
                .HasColumnName("ChamadoId")
                .IsRequired();

            builder.Property(h => h.UsuarioId)
                .HasColumnName("UsuarioId")
                .IsRequired();
        }
    }
}
