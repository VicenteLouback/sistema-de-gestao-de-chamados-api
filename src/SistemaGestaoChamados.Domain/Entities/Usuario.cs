namespace SistemaGestaoChamados.Domain.Entities;

/// <summary>
/// Representa um usuário do sistema.
/// </summary>
public class Usuario
{
    public Guid Id { get; private set; }

    public string Nome { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public DateTime DataCadastro { get; private set; }

    // Construtor utilizado pelo Entity Framework Core.
    private Usuario()
    {
    }

    /// <summary>
    /// Cria um novo usuário.
    /// </summary>
    public Usuario(string nome, string email)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        DataCadastro = DateTime.UtcNow;
    }
}