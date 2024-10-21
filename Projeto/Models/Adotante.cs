namespace Projeto.Models
{
    public class Adotante
    {
        public int AdotanteId { get; set; }
        public string Nome { get; set; }
        public string? Email { get; set; }
        public List<Adocao> Adocoes { get; set; } = new List<Adocao>();
    }
}
