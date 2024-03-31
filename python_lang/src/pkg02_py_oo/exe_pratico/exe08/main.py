from modelos.livro import Livro


def print_header(title: str) -> None:
    print('\n\n')
    print('*' * 10)
    print(f' - {title} \n')


def q02() -> None:
    """
    2. Na classe Livro, adicione um método especial str que retorna uma mensagem formatada com o título, autor e ano de publicação do livro. Crie duas instâncias da classe Livro e imprima essas instâncias.
    """
    print_header('Exercício 02')
    livro01 = Livro('Python Fluente', 'Luciano Ramalho', 2015)
    livro02 = Livro('Python Cookbook', 'David Beazley', 2013, False)

    print(livro01)
    print(livro02)


def q03() -> None:
    """
    3. Adicione um método de instância chamado emprestar à classe Livro que define o atributo disponivel como False. Crie uma instância da classe, chame o método emprestar e imprima se o livro está disponível ou não.
    """
    print_header('Exercício 03')
    livro = Livro('Python Fluente', 'Luciano Ramalho', 2015)
    print(livro)
    livro.emprestar()
    print(livro)


def q04() -> None:
    """
    4. Adicione um método estático chamado verificar_disponibilidade à classe Livro que recebe um ano como parâmetro e retorna uma lista dos livros disponíveis publicados nesse ano.
    """
    print_header('Exercício 04')
    livro01 = Livro('Python Fluente', 'Luciano Ramalho', 2015)
    livro02 = Livro('Python Cookbook v01', 'David Beazley', 2013, False)
    livro03 = Livro('Python Cookbook v02', 'David Beazley', 2013)
    livro04 = Livro('Python Cookbook v03', 'David Beazley', 2013, False)
    livro05 = Livro('Padrões de Projeto', 'GoF', 2013)

    livros = Livro.verificar_disponibilidade(2013)
    for livro in livros:
        print(livro)


if __name__ == '__main__':
    q02()
    q03()
    q04()
    # As questões 05 a 08 estão resolvidas nas implemnetações das questões 03, 04 e 02 respectivamente.
