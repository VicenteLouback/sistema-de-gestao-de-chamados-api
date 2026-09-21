namespace SistemaGestaoChamados.Application.Dtos.Chamada
{
    public class ChamadoDto
    {
        public int IdChamado { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int PrioridadeId { get; set; }
    }
}
