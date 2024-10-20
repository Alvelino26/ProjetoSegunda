namespace Adopet.Models
{
    public class Abrigo
    {
        public int AbrigoId { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public List<Animal> Animais { get; set; } = new List<Animal>();
    }
}
