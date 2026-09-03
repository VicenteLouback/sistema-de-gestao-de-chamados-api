using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entitie;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

public class InteracaoChamadoConfiguration : IEntityTypeConfiguration<InteracaoChamado>
{
    public void Configure(EntityTypeBuilder<InteracaoChamado> builder)
    {
        builder.ToTable("InteracaoChamado");

        builder.HasKey(ic => ic.Id);

        builder.Property(ic => ic.Mensagem)
            .IsRequired()
            .HasColumnType("varchar(max)");

        builder.Property(ic => ic.DataCriacao).IsRequired();
        builder.Property(ic => ic.ChamadoId).IsRequired();
        builder.Property(ic => ic.UsuarioId).IsRequired();
        builder.Property(ic => ic.Editada).IsRequired();
        builder.Property(ic => ic.DataEdicao).IsRequired(false);

        builder.HasOne(ic => ic.Chamado)
            .WithMany()
            .HasForeignKey(ic => ic.ChamadoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ic => ic.Usuario)
            .WithMany()
            .HasForeignKey(ic => ic.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}