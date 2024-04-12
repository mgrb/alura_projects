from modelos.cardapio.item_cardapio import ItemCardapio


class Sobremesa(ItemCardapio):
    def __init__(
        self,
        nome: str,
        preco: float,
        tipo: str,
        tamanho: str,
    ) -> None:
        super().__init__(nome, preco)
        self._tipo = tipo
        self._tamanho = tamanho

    def __str__(self):
        return f'{super().__str__()} - {self._tipo} - {self._tamanho}'

    def aplicar_desconto(self) -> None:
        self._preco *= 0.85
        print(
            f'O preço do(a) {self._nome} foi alterado para R${self._preco:.2f}',
        )
