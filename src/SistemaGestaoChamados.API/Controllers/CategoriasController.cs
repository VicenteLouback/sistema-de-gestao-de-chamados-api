using Microsoft.AspNetCore.Mvc;
using SistemaGestaoChamados.Application.Dtos.Categoria;
using SistemaGestaoChamados.Application.Interfaces;

namespace SistemaGestaoChamados.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        
        public CategoriasController(ICategoriaService categoriaService) 
        { 
           _categoriaService = categoriaService;
        }

        [HttpPost("criar-categoria")]
        public async Task<IActionResult> CriarCategoria(CriarCategoriaDto dto)
        {
            var categoria = await _categoriaService.CriarAsync(dto);
            return Ok(categoria);
        }
    }
}
