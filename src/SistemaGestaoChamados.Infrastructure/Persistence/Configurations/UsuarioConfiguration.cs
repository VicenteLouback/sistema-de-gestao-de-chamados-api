using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations;

/// <summary>
/// Configura o mapeamento da entidade Usuario para o banco de dados.
/// </summary>
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");

        builder.HasKey(usuario => usuario.Id);

        builder.Property(usuario => usuario.Nome)
            .HasColumnName("Nome")
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(usuario => usuario.Email)
            .HasColumnName("Email")
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(usuario => usuario.SenhaHash)
            .HasColumnName("SenhaHash")
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(usuario => usuario.PerffilId)
            .HasColumnName("PerfilId")
            .IsRequired();
    }
}