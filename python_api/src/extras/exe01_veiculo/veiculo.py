from abc import ABC, abstractmethod


class Veiculo(ABC):
    def __init__(self, marca: str, modelo: str) -> None:
        self._marca: str = marca
        self._modelo: str = modelo
        self._ligado: bool = False

    def __str__(self):
        return f'{self._marca} {self._modelo} {self.status}'

    @property
    def status(self) -> str:
        return 'ligado' if self._ligado else 'desligado'

    @abstractmethod
    def ligar(self) -> None:
        pass
