using Microsoft.AspNetCore.Mvc;
using SistemaGestaoChamados.Application.Dtos.Chamada;
using SistemaGestaoChamados.Application.Interfaces;

namespace SistemaGestaoChamados.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadosController : ControllerBase
    {
        private readonly IChamadoService _chamadoService;

        public ChamadosController(IChamadoService chamadoService)
        {
            _chamadoService = chamadoService;
        }


        [HttpPost("criar-chamado")]
        public async Task<IActionResult> Criar([FromBody] CriarChamadoDto dto)
        {
            var chamado = await _chamadoService.CriarAsync(dto);

            return Ok(chamado);
        }

        [HttpGet("listar-chamados")]
        public async Task<IActionResult> Get()
        {
            var chamados = await _chamadoService.ListarChamados();

            return Ok(chamados);
        }

        [HttpGet("buscar-chamado/{id:int}")]
        public async Task<IActionResult> BuscarPorId(int Id)
        {
            var chamado = await _chamadoService.BuscarChamado(Id);

            if(chamado == null)
                return NotFound();

            return Ok(chamado);
        }

        [HttpPut("atualizar-chamado/{id:int}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] AtualizarChamadoDto dto)
        {
            var chamado = await _chamadoService.AtualizarAsync(id, dto);

            if(chamado == null)
                return NotFound();

            return Ok(chamado);
        }

        [HttpDelete("deletar-chamado/{id:int}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var excluido = await _chamadoService.ExcluirAsync(id);

            if(!excluido)
                return NotFound();

            return NoContent();
        }
        
    }
}
