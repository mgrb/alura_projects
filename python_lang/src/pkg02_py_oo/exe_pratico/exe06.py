class Pessoa:
    def __init__(self, nome: str, idade: int, profissao: str):
        self._nome = nome
        self._idade = idade
        self._profissao = profissao

    def __str__(self):
        return (
            f'{self._nome} tem {self._idade} anos. Profissão: {self._profissao}'
        )

    @property
    def saudacao(self) -> str:
        return f'Olá, meu nome é {self._nome}'

    def aniversario(self) -> None:
        self._idade += 1


if __name__ == '__main__':
    pessoa = Pessoa('João', 30, 'Programador')
    print(pessoa)
    print(pessoa.saudacao)
