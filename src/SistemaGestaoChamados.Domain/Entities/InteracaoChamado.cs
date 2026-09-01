

namespace SistemaGestaoChamados.Domain.Entities
{
    public class InteracaoChamado
    {
        public int Id { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public int ChamadoId { get; set; }
        public int UsuarioId { get; set; }
    }
}
