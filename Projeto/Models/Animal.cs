namespace Projeto.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public bool DisponivelParaAdocao { get; set; }
        public int AbrigoId { get; set; }
        public Abrigo Abrigo { get; set; }
    }
}
