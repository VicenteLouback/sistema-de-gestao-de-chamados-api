using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

public class PerfilPermissaoConfiguration : IEntityTypeConfiguration<PerfilPermissao>
{
    public void Configure(EntityTypeBuilder<PerfilPermissao> builder)
    {
        builder.ToTable("PerfilPermissao");

        builder.HasKey(pp => new { pp.PerfilId, pp.PermissaoId });

        builder.HasOne(pp => pp.Perfil)
            .WithMany(p => p.PerfilPermissoes)
            .HasForeignKey(pp => pp.PerfilId);

        builder.HasOne(pp => pp.Permissao)
            .WithMany(p => p.PerfilPermissoes)
            .HasForeignKey(pp => pp.PermissaoId);
    }
}