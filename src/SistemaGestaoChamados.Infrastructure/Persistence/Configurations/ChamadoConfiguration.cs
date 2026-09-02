using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;


namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations
{
    public class ChamadoConfiguration : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("Chamados");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.CategoriaId).IsRequired();
            builder.Property(x => x.Prioridade).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.DataAbertura).IsRequired();
            builder.Property(x => x.DataFechamento);
        }
    }
}
