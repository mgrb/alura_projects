namespace ScreenSound.POO;


public class Musica
{
    public required string Nome { get; set; }
    public string? Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    private string DisponivelMsg{
        get => Disponivel ? "Sim" : "Não";
    }   
     public override string ToString()
    {
        return $"Nome: {Nome}, Artista: {Artista}, Duração: {Duracao}, Disponível: {DisponivelMsg}";
    }
}
