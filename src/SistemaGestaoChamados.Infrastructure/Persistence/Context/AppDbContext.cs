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
        public DbSet<Usuarios> Usuarios => Set<Usuarios>();
        public DbSet<Chamado> Chamados => Set<Chamado>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Perfil> Perfis => Set<Perfil>();
        public DbSet<InteracaoChamado> InteracoesChamados => Set<InteracaoChamado>();
        public DbSet<HistoricoChamado> HistoricosChamados => Set<HistoricoChamado>();
        public DbSet<Permissao> Permissoes => Set<Permissao>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chamado>().ToTable("Chamado");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Perfil>().ToTable("Perfil");
            modelBuilder.Entity<InteracaoChamado>().ToTable("InteracaoChamado");
            modelBuilder.Entity<HistoricoChamado>().ToTable("HistoricoChamado");
            modelBuilder.Entity<Permissao>().ToTable("Permissao");
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
        }
    }
}
