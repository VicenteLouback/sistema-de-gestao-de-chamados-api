
using SistemaGestaoChamados.Domain.Entities;
using SistemaGestaoChamados.Domain.Enums;

namespace SistemaGestaoChamados.Application.Dtos
{
    public class CriarChamadoDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public PrioridadeChamado Prioridade { get; set; }
        public StatusChamado Status { get; set; }
        public int UsuarioId { get; set; }
    }
}
