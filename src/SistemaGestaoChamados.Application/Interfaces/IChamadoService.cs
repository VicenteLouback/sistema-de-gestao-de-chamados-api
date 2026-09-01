using SistemaGestaoChamados.Application.Dtos;


namespace SistemaGestaoChamados.Application.Interfaces
{
    public interface IChamadoService
    {
        Task<CriarChamadoDto> CriarAsync(CriarChamadoDto dto);
        Task<List<ListarChamadosDto>> ListarChamados();
         Task<ListarChamadosDto?> BuscarChamado(int Id);
        Task<ChamadoDto?> AtualizarAsync(int id, AtualizarChamadoDto dto);
        Task<bool> ExcluirAsync(int id);
    }
}
