

namespace SistemaGestaoChamados.Domain.Entities
{
    public class HistoricoChamado
    {
        public int Id { get; set; }
        public string CampoAlterado { get; set; } = string.Empty;
        public string ValorAnterior { get; set; } = string.Empty;
        public string ValorNovo { get; set; } = string.Empty;
        public DateTime DataAlteracao { get; set; }
        public int ChamadoId { get; set; }
        public int UsuarioId { get; set; }
    }
}
