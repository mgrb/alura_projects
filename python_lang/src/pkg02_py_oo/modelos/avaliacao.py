class Avaliacao:
    def __init__(self, cliente: str, nota: float) -> None:
        self._cliente = cliente.title()
        self._nota = nota

    def __str__(self) -> str:
        return f'{self._cliente.ljust(20)} - {self._nota:.1f}'
