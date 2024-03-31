from veiculo import Veiculo


class Carro(Veiculo):
    def __init__(self, marca: str, modelo: str, portas: int) -> None:
        super().__init__(marca, modelo)
        self._portas: int = portas

    def __str__(self) -> str:
        return f'{super().__str__()} - {self._portas} portas'
