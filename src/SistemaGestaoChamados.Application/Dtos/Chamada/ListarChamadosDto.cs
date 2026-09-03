using SistemaGestaoChamados.Domain.Entities;
using SistemaGestaoChamados.Domain.Enums;


namespace SistemaGestaoChamados.Application.Dtos.Chamada
{
    public class ListarChamadosDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public PrioridadeChamado Prioridade { get; set; }
        public StatusChamado Status { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public Guid? AtendenteId { get; set; }
        public Usuario? Atendente { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataResolucao { get; set; }
        public DateTime? DataFechamento { get; set; }
    }
}
