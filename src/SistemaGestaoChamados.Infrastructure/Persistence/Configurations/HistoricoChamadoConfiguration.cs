using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

public class HistoricoChamadoConfiguration : IEntityTypeConfiguration<HistoricoChamado>
{
    public void Configure(EntityTypeBuilder<HistoricoChamado> builder)
    {
        builder.ToTable("HistoricoChamado");

        builder.HasKey(h => h.Id);

        builder.Property(h => h.DataAlteracao).IsRequired();
        builder.Property(h => h.ChamadoId).IsRequired();
        builder.Property(h => h.UsuarioId).IsRequired();
        builder.Property(h => h.TipoAcao).IsRequired();

        builder.Property(h => h.Descricao)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(h => h.StatusAnterior).IsRequired(false);
        builder.Property(h => h.StatusNovo).IsRequired(false);

        builder.HasOne(h => h.Chamado)
            .WithMany()
            .HasForeignKey(h => h.ChamadoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(h => h.Usuario)
            .WithMany()
            .HasForeignKey(h => h.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}