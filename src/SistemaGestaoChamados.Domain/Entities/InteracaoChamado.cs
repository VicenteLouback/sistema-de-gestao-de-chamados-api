

namespace SistemaGestaoChamados.Domain.Entities
{
    public class InteracaoChamado
    {
        public int IdInteracao { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public int ChamadoId { get; set; }
        public int AutorId { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}

