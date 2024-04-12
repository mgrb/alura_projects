from veiculo import Veiculo


class Moto(Veiculo):
    def __init__(self, marca: str, modelo: str, tipo: str) -> None:
        super().__init__(marca, modelo)
        self._tipo: str = tipo

    def __str__(self) -> str:
        return f'{super().__str__()} - {self._tipo}'

    def ligar(self) -> None:
        self._ligado = True
        print(f'A {self.__class__.__name__} foi ligada')
