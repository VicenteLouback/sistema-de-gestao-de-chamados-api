using SistemaGestaoChamados.Domain.Enums;

namespace SistemaGestaoChamados.Domain.Entities;

/// <summary>
/// Representa um usuário do sistema.
/// </summary>
public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public DateTime DataCadastro { get; private set; }
    public Status Status { get; private set; }

    // Construtor utilizado pelo Entity Framework Core.
    private Usuario()
    {
    }

    public Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
        DataCadastro = DateTime.UtcNow;
    }
}