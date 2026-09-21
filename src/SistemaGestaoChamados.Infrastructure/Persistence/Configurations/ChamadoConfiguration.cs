using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

public class ChamadoConfiguration : IEntityTypeConfiguration<Chamado>
{
    public void Configure(EntityTypeBuilder<Chamado> builder)
    {
        builder.ToTable("Chamados");

        builder.HasKey(x => x.IdChamado);
        builder.Property(x => x.Titulo).HasColumnName("Titulo").IsRequired();
        builder.Property(x => x.Descricao).HasColumnName("Descricao").IsRequired();
        builder.Property(x => x.Prioridade).HasColumnName("Prioridade").IsRequired();
        builder.Property(x => x.Status).HasColumnName("Status").IsRequired();
        builder.Property(x => x.SolicitanteId).HasColumnName("SolicitanteId").IsRequired();
        builder.Property(x => x.ResponsavelId).HasColumnName("ResponsavelId");
        builder.Property(x => x.CategoriaId).HasColumnName("CategoriaId").IsRequired();
        builder.Property(x => x.DataCriacao).HasColumnName("DataCriacao").IsRequired();
        builder.Property(x => x.DataAtualizacao).HasColumnName("DataAtualizacao");
    }
}