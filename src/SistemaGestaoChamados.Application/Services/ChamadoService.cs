using Microsoft.EntityFrameworkCore;
using SistemaGestaoChamados.Application.Dtos;
using SistemaGestaoChamados.Application.Interfaces;
using SistemaGestaoChamados.Domain.Entities;
using SistemaGestaoChamados.Domain.Enums;
using SistemaGestaoChamados.Infrastructure.Persistence.Context;

namespace SistemaGestaoChamados.Application.Services;

public class ChamadoService : IChamadoService
{
    private readonly AppDbContext _context;

    public ChamadoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<CriarChamadoDto> CriarAsync(CriarChamadoDto dto)
    {
        if (dto == null)
            throw new ArgumentNullException(nameof(dto));

            var chamado = new Chamado
            {
                Titulo = dto.Titulo.Trim(),
                Descricao = dto.Descricao.Trim(),
                CategoriaId = dto.CategoriaId,
                Prioridade = dto.Prioridade,
                Status = StatusChamado.Novo,
                UsuarioId = dto.UsuarioId,
                DataAbertura = DateTime.UtcNow,
            };

            await _context.Chamados.AddAsync(chamado);
            await _context.SaveChangesAsync();

            return dto;
     
    }

    public async Task<List<ListarChamadosDto>> ListarChamados()
    {
        return await _context.Chamados
             .Select(c => new ListarChamadosDto
             {
                 Titulo = c.Titulo,
                 Descricao = c.Descricao,
                 CategoriaId = c.CategoriaId,
                 Prioridade = c.Prioridade,
                 Status = c.Status,
                 UsuarioId = c.UsuarioId,
                 DataAbertura = c.DataAbertura,
                 DataAtualizacao = c.DataAtualizacao,
                 DataResolucao = c.DataResolucao,
                 DataFechamento = c.DataFechamento
             })
             .ToListAsync();
    }

    public async Task<ListarChamadosDto?> BuscarChamado(int id)
    {
        return await _context.Chamados
           .Where(c => c.Id == id)
           .Select(c => new ListarChamadosDto
           {
               Titulo = c.Titulo,
               Descricao = c.Descricao,
               CategoriaId = c.CategoriaId,
               Prioridade = c.Prioridade,
               Status = c.Status,
               UsuarioId = c.UsuarioId,
               DataAbertura = c.DataAbertura,
               DataAtualizacao = c.DataAtualizacao,
               DataResolucao = c.DataResolucao,
               DataFechamento = c.DataFechamento
           })
           .FirstOrDefaultAsync();
    }

    public async Task<ChamadoDto?> AtualizarAsync(int id, AtualizarChamadoDto dto)
    {
        var chamado = await _context.Set<Chamado>().FirstOrDefaultAsync(x => x.Id == id);

        if (chamado == null)
            return null;

        chamado.Titulo = dto.Titulo ?? chamado.Titulo;
        chamado.Descricao = dto.Descricao ?? chamado.Descricao;
        chamado.Prioridade = dto.Prioridade != 0 ? dto.Prioridade : chamado.Prioridade;
        chamado.DataAtualizacao = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new ChamadoDto
        {
            Titulo = chamado.Titulo,
            Descricao = chamado.Descricao,
            PrioridadeId = (int)chamado.Prioridade
        };
    }

    public async Task<bool> ExcluirAsync(int id)
    {
        var chamado = await _context.Chamados.FirstOrDefaultAsync(x => x.Id == id);

        if(chamado == null)
            return false;

        _context.Chamados.Remove(chamado);

        await _context.SaveChangesAsync();

        return true;
    }
}