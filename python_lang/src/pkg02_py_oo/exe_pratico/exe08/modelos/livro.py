class Livro:
    _acervo: list = []

    def __init__(
        self,
        titulo: str,
        autor: str,
        ano_publicacao: int,
        disponivel: bool = True,
    ) -> None:
        self._titulo = titulo
        self._autor = autor
        self._ano_publicacao = ano_publicacao
        self._disponivel = disponivel
        Livro._acervo.append(self)

    def __str__(self) -> str:
        return f'{self._titulo} - {self._autor} - {self._ano_publicacao} - {self.disponivel}'

    @property
    def disponivel(self) -> str:
        return '✅' if self._disponivel else '⛔'

    def emprestar(self):
        self._disponivel = False

    @classmethod
    def verificar_disponibilidade(cls, ano_publica: int) -> list:
        return [
            livro
            for livro in cls._acervo
            if (livro._ano_publicacao == ano_publica and livro._disponivel)
        ]
