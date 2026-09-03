using SistemaGestaoChamados.Domain.Enums;

namespace SistemaGestaoChamados.Domain.Entities
{
    public class HistoricoChamado
    {
        public int Id { get; set; }
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
        public int TipoAcao { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public StatusChamado? StatusAnterior { get; set; }
        public StatusChamado? StatusNovo { get; set; }

        public int ChamadoId { get; set; }
        public Chamado? Chamado { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}

