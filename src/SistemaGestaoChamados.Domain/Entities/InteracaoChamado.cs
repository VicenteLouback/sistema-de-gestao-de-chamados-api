using SistemaGestaoChamados.Domain.Entities;

namespace SistemaGestaoChamados.Domain.Entitie
{
    public class InteracaoChamado
    {
        public int Id { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public bool Editada { get; set; } = false;
        public DateTime? DataEdicao { get; set; }

        // Chaves e Navegações
        public int ChamadoId { get; set; }
        public Chamado? Chamado { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}

