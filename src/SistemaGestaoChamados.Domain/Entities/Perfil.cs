namespace SistemaGestaoChamados.Domain.Entities
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

        public ICollection<PerfilPermissao> PerfilPermissoes { get; set; } = new List<PerfilPermissao>();
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}

