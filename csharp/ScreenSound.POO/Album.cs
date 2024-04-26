namespace ScreenSound.POO;

public class Album
{
    public string Nome { get; set; }
    public int Ano { get; set; }
    public List<Musica> Musicas { get; set; } = [];
    public int DuracaoTotal
    {
        get => Musicas.Sum(m => m.Duracao);
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

}
