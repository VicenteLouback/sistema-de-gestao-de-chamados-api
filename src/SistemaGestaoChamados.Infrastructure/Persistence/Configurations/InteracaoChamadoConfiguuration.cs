using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

public class InteracaoChamadoConfiguration : IEntityTypeConfiguration<InteracaoChamado>
{
    public void Configure(EntityTypeBuilder<InteracaoChamado> builder)
    {
        builder.ToTable("InteracaoChamados");

        builder.HasKey(ic => ic.IdInteracao);
        builder.Property(ic => ic.Mensagem).HasColumnName("Mensagem").IsRequired();
        builder.Property(ic => ic.DataCriacao).IsRequired();
        builder.Property(ic => ic.ChamadoId).IsRequired();
        builder.Property(ic => ic.AutorId).IsRequired();
        builder.Property(ic => ic.Tipo).IsRequired();

    }
}