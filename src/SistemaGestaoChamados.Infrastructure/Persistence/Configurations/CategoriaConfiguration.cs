using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(c => c.IdCategoria);
            builder.Property(c => c.Nome).HasColumnName("Nome").IsRequired();
            builder.Property(c => c.Ativa).HasColumnName("Ativa").IsRequired();
            builder.Property(c => c.DataCadastro).HasColumnName("DataCadastro").IsRequired();
        }
    }
}
