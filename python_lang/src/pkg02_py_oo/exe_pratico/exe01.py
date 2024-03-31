# Esta implementação já satifaz o exe 01 e o exe 04.
class Musicas:
    def __init__(self, nome: str, artista: str, duracao: int):
        self.titulo = nome
        self.artista = artista
        self.album = duracao

    def __str__(self):
        return f'{self.titulo.ljust(30)} | {self.artista.ljust(30)}| {self.album} minutos'


if __name__ == '__main__':
    colecao: list[Musicas] = []
    colecao.append(Musicas('Astronaut in the Ocean', 'Masked Wolf', 2))
    colecao.append(Musicas('Save Your Tears', 'The Weeknd', 4))
    colecao.append(Musicas('Blinding Lights', 'The Weeknd', 3))
    colecao.append(Musicas('Without You', 'The Kid LAROI', 2))

    print('Coleção de músicas:')
    for musica in colecao:
        print(musica)
