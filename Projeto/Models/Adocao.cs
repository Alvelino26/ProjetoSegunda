namespace Adopet.Models
{
    public class Adocao
    {
        public int AdocaoId { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int AdotanteId { get; set; }
        public Adotante Adotante { get; set; }
        public DateTime DataAdocao { get; set; } = DateTime.Now;
        public StatusAdocao Status { get; set; }
    }

    public enum StatusAdocao
    {
        EmAndamento,
        Concluida,
        Cancelada
    }
}
