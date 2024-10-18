public class Adocao
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public Animal Animal { get; set; }
    public int AdotanteId { get; set; }
    public Adotante Adotante { get; set; }
    public string Status { get; set; } // Pendente, Concluída, Cancelada
}