"""
Classe Restaurante
"""

from modelos.avaliacao import Avaliacao


class Restaurante:
    """
    Representa um restaurante
    """

    _restaurantes: list = []

    def __init__(self, nome: str, categoria: str, status: bool = False):
        """
        Construtor da classe Restaurante
        Input:
            - nome (str): Nome do restaurante
            - categoria (str): Categoria do restaurante
            - status (bool) Status de atividade do restaurante. (Opcional, padrão: False)
        """
        self._nome = nome.title()
        self._categoria = categoria.upper()
        self._status = status
        self._avaliacoes: list = []
        Restaurante._restaurantes.append(self)

    def __str__(self):
        """
        Retorna uma string formatada com os atributos do restaurante
        """
        return f'{self._nome.ljust(30)} | {self._categoria.ljust(15)} | {str(self.media_avaliacoes).rjust(10)} | {self.status}'

    @classmethod
    def listar_restaurantes(cls) -> None:
        """
        Lista os restaurantes cadastrados
        """
        print(
            f'{"Nome".ljust(30)} | {"Categoria".ljust(15)} | {"Avaliação".ljust(10)} | {"Status"}'
        )
        for restaurante in cls._restaurantes:
            print(restaurante)

    @property
    def status(self) -> str:
        """
        Retorna o status do restaurante
        Output:
            - str: Status do restaurante
        """
        return '✅' if self._status else '⛔'

    def alternar_status(self):
        """
        Alterna o status do restaurante
        """
        self._status = not self._status

    def receber_avaliacao(self, cliente: str, nota: float) -> None:
        """
        Recebe uma avaliação de um cliente
        Input:
            - client (str): Nome do cliente
            - nota (float): Nota da avaliação
        """
        avaliacao = Avaliacao(cliente, nota)
        self._avaliacoes.append(avaliacao)

    @property
    def media_avaliacoes(self) -> float:
        """
        Retorna a média das avaliações do restaurante
        Output:
            - float: Média das avaliações
        """
        return (
            round(
                sum([avaliacao._nota for avaliacao in self._avaliacoes])
                / len(self._avaliacoes),
                1,
            )
            if len(self._avaliacoes) > 0
            else 0
        )
