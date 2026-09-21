using SistemaGestaoChamados.Domain.Enums;

namespace SistemaGestaoChamados.Domain.Entities
{
    public class Chamado
    {
        public int IdChamado { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public PrioridadeChamado Prioridade { get; set; }
        public StatusChamado Status { get; set; }
        public int SolicitanteId { get; set; }
        public int? ResponsavelId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }
    }
}

