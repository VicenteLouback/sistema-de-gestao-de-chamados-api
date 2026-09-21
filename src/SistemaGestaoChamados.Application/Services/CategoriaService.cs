using SistemaGestaoChamados.Application.Dtos.Categoria;
using SistemaGestaoChamados.Application.Interfaces;
using SistemaGestaoChamados.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoChamados.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly AppDbContext _context;

        public CategoriaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CriarCategoriaDto> CriarAsync(CriarCategoriaDto dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            var categoria = await _context.Categorias
                        .FirstOrDefaultAsync(c => c.Nome == dto.Nome);
            if (categoria != null)
                throw new InvalidOperationException("Categoria já existe");

            return dto;
        }
    }
}
