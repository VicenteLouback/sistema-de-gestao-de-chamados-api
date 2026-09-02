using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;


namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations
{
    public class PermissaoConfiguration : IEntityTypeConfiguration<Permissao>
    {
        public void Configure(EntityTypeBuilder<Permissao> builder)
        {
            builder.ToTable("Permissao");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
