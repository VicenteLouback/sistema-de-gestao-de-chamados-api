namespace SistemaGestaoChamados.Domain.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; } = string.Empty;
        public bool Ativa { get; set; } = true;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}

