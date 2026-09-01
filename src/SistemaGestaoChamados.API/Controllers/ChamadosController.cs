using Microsoft.AspNetCore.Mvc;
using SistemaGestaoChamados.Application.Dtos;
using SistemaGestaoChamados.Application.Interfaces;
using SistemaGestaoChamados.Domain.Entities;

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


        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] CriarChamadoDto dto)
        {
            var chamado = await _chamadoService.CriarAsync(dto);

            return Ok(chamado);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var chamados = await _chamadoService.ListarChamados();

            return Ok(chamados);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> BuscarPorId(int Id)
        {
            var chamado = await _chamadoService.BuscarChamado(Id);

            if(chamado == null)
                return NotFound("Chamado não encontrado");

            return Ok(chamado);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] AtualizarChamadoDto dto)
        {
            var chamado = await _chamadoService.AtualizarAsync(id, dto);

            if(chamado == null)
                return NotFound("Chamado não encontrado");

            return Ok(chamado);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var excluido = await _chamadoService.ExcluirAsync(id);

            if(!excluido)
                return NotFound("Chamado não encontrado");

            return NoContent();
        }
        
    }
}
