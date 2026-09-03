namespace SistemaGestaoChamados.Domain.Entities
{
    public class Permissao
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string Modulo { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;

        public ICollection<PerfilPermissao> PerfilPermissoes { get; set; } = new List<PerfilPermissao>();
    }
}

