

namespace SistemaGestaoChamados.Application.Dtos
{
    public class ChamadoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int PrioridadeId { get; set; }
    }
}
