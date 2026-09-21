using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");

        builder.HasKey(u => u.IdUsuario);
        builder.Property(u => u.Nome).HasColumnName("Nome").IsRequired();
        builder.Property(u => u.Email).HasColumnName("Email").IsRequired();
        builder.Property(u => u.SenhaHash).HasColumnName("SenhaHash").IsRequired();
        builder.Property(u => u.Perfil).HasColumnName("Perfil").IsRequired();
        builder.Property(u => u.Ativo).HasColumnName("Ativo").IsRequired();
        builder.Property(u => u.DataCriacao).HasColumnName("DataCriacao").IsRequired();

    }
}