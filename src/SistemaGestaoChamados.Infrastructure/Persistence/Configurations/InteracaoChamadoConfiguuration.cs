using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations
{
    public class InteracaoChamadoConfiguuration : IEntityTypeConfiguration<InteracaoChamado>
    {
        public void Configure(EntityTypeBuilder<InteracaoChamado> builder)
        {
            builder.ToTable("InteracaoChamado");
            builder.HasKey(ic => ic.Id);
            builder.Property(ic => ic.Mensagem)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(ic => ic.DataCriacao)
                .IsRequired();
            builder.Property(ic => ic.ChamadoId)
                .IsRequired();
            builder.Property(ic => ic.UsuarioId)
                .IsRequired();
        }
    }
}
