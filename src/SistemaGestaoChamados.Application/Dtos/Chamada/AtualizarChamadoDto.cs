using SistemaGestaoChamados.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoChamados.Application.Dtos.Chamada
{
    public class AtualizarChamadoDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public PrioridadeChamado Prioridade { get; set; }
    }
}
