from modelos.cardapio.item_cardapio import ItemCardapio


class Prato(ItemCardapio):
    def __init__(self, nome: str, preco: float, descricao: str) -> None:
        super().__init__(nome, preco)
        self._descricao = descricao

    def __str__(self):
        return f'{self._nome} - R${self._preco:.2f} - {self._descricao}'

    def aplicar_desconto(self) -> None:
        self._preco *= 0.92
        print(
            f'O preço do(a) {self._nome} foi alterado para R${self._preco:.2f}',
        )
