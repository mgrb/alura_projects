class Corro:
    def __init__(self, modelo: str, cor: str, ano: int):
        self.modelo = modelo
        self.cor = cor
        self.ano = ano

    def __str__(self):
        return f'{self.modelo.ljust(30)} | {self.cor.ljust(30)} | {self.ano}'


class Resturante:
    def __init__(
        self,
        nome: str,
        categoria: str,
        endereco: str = '',
        qtd_strelas: int = None,
        status: bool = False,
    ):
        self.nome = nome
        self.categoria = categoria
        self.endereco = endereco
        self.qtd_strelas = qtd_strelas
        self.status = status

    def __str__(self):
        return f'{self.nome.ljust(30)} | {self.categoria.ljust(30)} | {self.endereco.ljust(30)} | {self.qtd_strelas} | {self.status}'


class Cliente:
    def __init__(
        self,
        nome: str,
        idade: int,
        genero: str = 'Ñ Informado',
        endereco: str = '',
    ):
        self.nome = nome
        self.idade = idade
        self.genero = genero
        self.endereco = endereco

    def __str__(self):
        return f'{self.nome.ljust(30)} | {self.idade} | {self.genero.ljust(15)} | {self.endereco.ljust(30)}'


if __name__ == '__main__':
    print('Exercício 01')
    carros: list[Corro] = []
    carros.append(Corro('Fusca', 'Azul', 1970))
    carros.append(Corro('Chevette', 'Amarelo', 1980))
    print('Carros:')
    for carro in carros:
        print(carro)

    print('\nExercício 02')
    restaurantes: list[Resturante] = []
    restaurantes.append(
        Resturante('Pizzaria do Python', 'Pizzaria', 'Rua 1', 3)
    )
    restaurantes.append(Resturante('Pizza Place', 'Fast Food'))
    print('Restaurantes:')
    for restaurante in restaurantes:
        print(restaurante)

    print('\nExercício 03')
    print('Done no anteior!')

    print('\nExercício 04')
    print('Done no anteior!')

    print('\nExercício 05')
    clientes: list[Cliente] = []
    clientes.append(Cliente('João', 25, 'M', 'Rua 1'))
    clientes.append(Cliente('Maria', 30, 'F', 'Rua 2'))
    clientes.append(Cliente('José', 35))
    print('Clientes:')
    for cliente in clientes:
        print(cliente)
