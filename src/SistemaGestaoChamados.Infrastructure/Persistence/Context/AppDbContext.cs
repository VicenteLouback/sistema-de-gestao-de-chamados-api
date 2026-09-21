using Microsoft.EntityFrameworkCore;
using SistemaGestaoChamados.Domain.Entities;


namespace SistemaGestaoChamados.Infrastructure.Persistence.Context
{
    /// <summary>
    /// Contexto principal de acesso ao banco de dados.
    /// O EF Core utiliza esta classe para mapear as entidades
    /// da aplicação para as tabelas do SQL Server.
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Representa a tabela de usuários no banco de dados.
        /// </summary>
        public DbSet<Usuario> Usuario => Set<Usuario>();
        public DbSet<Chamado> Chamados => Set<Chamado>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<InteracaoChamado> InteracoesChamados => Set<InteracaoChamado>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<Chamado>().ToTable("Chamados");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<InteracaoChamado>().ToTable("InteracoesChamados");

        }
    }
}
