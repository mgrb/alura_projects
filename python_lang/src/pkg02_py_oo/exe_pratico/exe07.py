class ContaBancaria:
    def __init__(self, titular: str, saldo: float, ativo: bool = False) -> None:
        self._titular = titular
        self._saldo = saldo
        self._ativo = ativo

    def __str__(self) -> str:
        return f'{self._titular} - R$ {self._saldo:.2f} - {self.ativo}'

    @property
    def ativo(self) -> bool:
        return '✅' if self._ativo else '⛔'

    @property
    def saldo(self) -> float:
        return self._saldo

    @property
    def titular(self) -> str:
        return self._titular

    def alternar_ativo(self) -> None:
        self._ativo = not self._ativo


class ClienteBanco:
    def __init__(
        self, nome: str, idade: int, profissao: str, cpf: str, endereco: str
    ):
        self._nome = nome
        self._idade = idade
        self._profissao = profissao
        self._cpf = cpf
        self._endereco = endereco

    def criarconta(self, saldo: float) -> ContaBancaria:
        return ContaBancaria(self._nome, saldo)


if __name__ == '__main__':
    conta1 = ContaBancaria('João', 1000.0)
    conta2 = ContaBancaria('Maria', 2000.0)
    print(conta1)
    print(conta2)
    print(f'Ativando conta de {conta1.titular}')
    print(conta1.alternar_ativo())
    print(conta1)

    cliente1 = ClienteBanco(
        'João', 30, 'Desenvolvedor', '123.456.789-00', 'Rua Python, 123'
    )
    cliente2 = ClienteBanco(
        'Maria', 25, 'Designer', '987.654.321-00', 'Rua Java, 456'
    )
    cliente3 = ClienteBanco(
        'José', 35, 'Gerente', '456.789.123-00', 'Rua C#, 789'
    )

    cc: ContaBancaria = cliente3.criarconta(5000.0)
    print(f'Conta criada para {cc.titular}:')
    print(cc)
