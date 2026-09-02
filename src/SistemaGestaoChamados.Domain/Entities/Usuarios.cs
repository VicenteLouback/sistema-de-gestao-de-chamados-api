

namespace SistemaGestaoChamados.Domain.Entities
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
    }
}
