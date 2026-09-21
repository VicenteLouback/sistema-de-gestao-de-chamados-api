using SistemaGestaoChamados.Application.Dtos.Categoria;


namespace SistemaGestaoChamados.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<CriarCategoriaDto> CriarAsync(CriarCategoriaDto dto);
    }
}
