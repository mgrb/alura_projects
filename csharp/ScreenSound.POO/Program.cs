using ScreenSound.POO;

Musica musica1 = new()
{
    Nome = "Nome da Música",
    Artista = "Nome do Artista",
    Duracao = 180,
    Disponivel = true
};

Musica musica2 = new()
{
    Nome = "Nome da Música 2",
    Artista = "Nome do Artista 2",
    Duracao = 200,
    Disponivel = true
};

Album album = new()
{
    Nome = "Nome do Álbum",
    Ano = 2021
};

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);


Console.WriteLine("Listado de músicas do álbum: ");
Console.WriteLine($"Nome do Álbum: {album.Nome}");
Console.WriteLine($"Ano: {album.Ano}");
Console.WriteLine($"Duração total: {album.DuracaoTotal} segundos");
foreach (var musica in album.Musicas)
{
    Console.WriteLine($"Nome: {musica.Nome}");
    Console.WriteLine($"Artista: {musica.Artista}");
    Console.WriteLine($"Duração: {musica.Duracao} segundos");
    Console.WriteLine($"Disponível: {musica.Disponivel}");
    Console.WriteLine();
}