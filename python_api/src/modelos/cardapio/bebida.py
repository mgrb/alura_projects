class Bebida:
    def __init__(self, nome: str, preco: float, tamanho: int) -> None:
        self._nome = nome
        self._preco = preco
        self._tamanho = tamanho

    def __str__(self):
        return f'{self.nome} - R${self.preco:.2f} - {self.tamanho}ml'
