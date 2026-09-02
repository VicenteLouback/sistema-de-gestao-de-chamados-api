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
    public string SenhaHash { get; private set; } = string.Empty;
    public int PerffilId { get; private set; }
}