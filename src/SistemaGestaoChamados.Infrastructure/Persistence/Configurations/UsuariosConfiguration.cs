using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGestaoChamados.Domain.Entities;


namespace SistemaGestaoChamados.Infrastructure.Persistence.Configurations
{
    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios"); 

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.DataCadastro)
                .HasColumnName("DataCadastro")
                .IsRequired();
        }
    }
}
