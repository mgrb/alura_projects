from modelos.restaurante import Restaurante


def main() -> None:
    exercicio_03()
    print('---')
    exercicio_04()


def exercicio_03() -> None:
    """
    Exercício 03
    Descrito na URI do curso: https://cursos.alura.com.br/course/python-aplicando-orientacao-objetos/task/147014
    """
    restaurante_praca = Restaurante('Pizzaria do Python', 'Pizzaria')

    # 01. Atribua o valor 'Italiana' ao atributo categoria da instância restaurante_praca da classe Restaurante.
    restaurante_praca._categoria = 'Italiana'

    # 02. Acesse o valor do atributo nome da instância restaurante_praca da classe Restaurante.
    print(restaurante_praca._nome)

    # 03. Verifique o valor inicial do atributo ativo para a instância restaurante_praca e exiba uma mensagem informando se o restaurante está ativo ou inativo.
    print(
        'Restaurante ativo'
        if restaurante_praca.status
        else 'Restaurante inativo'
    )

    # 04. Acesse o valor do atributo de classe categoria diretamente da classe Restaurante e armazene em uma variável chamada categoria.
    categoria = restaurante_praca._categoria

    # 05. Altere o valor do atributo nome para 'Bistrô'.
    restaurante_praca._nome = 'Bistrô'

    # 06. Crie uma nova instância da classe Restaurante chamada restaurante_pizza com o nome 'Pizza Place' e categoria 'Fast Food'.
    restaurante_pizza = Restaurante('Pizza Place', 'Fast Food')

    # 07. Verifique se a categoria da instância restaurante_pizza é 'Fast Food'.
    print('Fast Food' == restaurante_pizza._categoria)

    # 08. Mude o estado da instância restaurante_pizza para ativo.
    restaurante_pizza.alternar_status()

    # 09. Imprima no console o nome e a categoria da instância restaurante_praca.
    print(f'{restaurante_praca._nome} - {restaurante_praca._categoria}')


def exercicio_04() -> None:
    """
    Exercício 04
    Descrito na URI do curso: https://cursos.alura.com.br/course/python-aplicando-orientacao-objetos/task/147015
    """
    restaurante_praca = Restaurante('Pizzaria do Python', 'Pizzaria')
    restaurante_pizza = Restaurante('Pizza Place', 'Fast Food')

    Restaurante.listar_restaurantes()


if __name__ == '__main__':
    # exercicio_03()
    # print('---')
    # exercicio_04()
    main()
