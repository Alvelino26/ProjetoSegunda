public class Abrigo
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public ICollection<Animal>? Animais { get; set; }
}

//teste rambo 22
