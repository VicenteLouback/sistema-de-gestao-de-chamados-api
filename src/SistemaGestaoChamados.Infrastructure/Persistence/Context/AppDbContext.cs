using Microsoft.EntityFrameworkCore;
using SistemaGestaoChamados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
        public DbSet<Usuario> Usuarios => Set<Usuario>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly);
        }
    }
}
