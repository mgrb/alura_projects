import os

restaurante_repo = [
    {'nome': 'Bonamazza Pizzaria', 'categoria': 'x', 'ativo': True},
    {'nome': 'Brazetos Churrascaria', 'categoria': 'x', 'ativo': True},
    {'nome': 'Casa do Pastel', 'categoria': 'x', 'ativo': True},
    {'nome': 'Casa do Pão de Queijo', 'categoria': 'x', 'ativo': True},
]


def print_header() -> None:
    """
    Função que imprime o cabeçalho do sistema
    """
    print("""
░██████╗░█████╗░██████╗░░█████╗░██████╗░  ███████╗██╗░░██╗██████╗░██████╗░███████╗░██████╗░██████╗
██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔════╝╚██╗██╔╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝
╚█████╗░███████║██████╦╝██║░░██║██████╔╝  █████╗░░░╚███╔╝░██████╔╝██████╔╝█████╗░░╚█████╗░╚█████╗░
░╚═══██╗██╔══██║██╔══██╗██║░░██║██╔══██╗  ██╔══╝░░░██╔██╗░██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░╚═══██╗
██████╔╝██║░░██║██████╦╝╚█████╔╝██║░░██║  ███████╗██╔╝╚██╗██║░░░░░██║░░██║███████╗██████╔╝██████╔╝
╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░╚═════╝░
    """)


def print_menu() -> None:
    """
    Função que imprime o menu do sistema
    """

    print("""
    --------------------------------
        OPÇÕES DO SISTEMA
    --------------------------------
    1. Cadastrar restaurante
    2. Listar restaurante
    3. Ativar restaurante
    0. Sair
    """)


def print_titulo_tela(titulo: str) -> None:
    """
    Função que imprime o título da tela

    Input:
        titulo: str -> Título da tela
    """
    moldura = '+' * (len(titulo) + 4)
    print(moldura)
    print(f'+ {titulo} +')
    print(moldura)


def get_opcao() -> int:
    """
    Função que captura a opção escolhida pelo usuário

    Output:
        opc: int -> Opção escolhida pelo usuário
    """
    opc: int = 0
    try:
        opc = int(input('Escolha uma opção: '))
        print(f'Você escolheu a opção: {opc}')
    except ValueError:
        print('Opção inválida')
        opc = 99
    return opc


def executar_opcao(opcao: int) -> None:
    """
    Função que executa a opção escolhida pelo usuário

    Input:
        opcao: int -> Opção escolhida pelo usuário
    """
    os.system('clear')
    match opcao:
        case 1:
            cadastrar_restaurante()
        case 2:
            listar_restaurantes()
        case 3:
            alternar_status_restaurante()
        case 0:
            os.system('clear')
            print('Saindo do sistema')
            exit(0)
        case _:
            print('Opção inválida')


def cadastrar_restaurante() -> None:
    """
    Função que cadastra um restaurante
    """
    while True:
        print_titulo_tela('Cadastrando restaurante')

        nome_restalrante = input(
            'Digite o nome do restaurante que deseja cadastrar: '
        )
        nome_categoria = input(
            'Digite a categoria do restaurante que deseja cadastrar: '
        )
        restaurante = {
            'nome': nome_restalrante,
            'categoria': nome_categoria,
            'ativo': False,
        }
        restaurante_repo.append(restaurante)
        print(f'Restaurante {nome_restalrante} cadastrado com sucesso!')

        cadastrar_restaurante = voltar_menu_principal(
            msg='Deseja cadastrar um restaurante? (s/n): ',
            is_yes_or_no_question=True,
        )

        if not cadastrar_restaurante:
            break


def voltar_menu_principal(
    msg: str = 'Pressione qualquer tecla para voltar ao menu: ',
    is_yes_or_no_question: bool = False,
) -> bool:
    """
    Função que pergunta se o usuário deseja voltar ao menu principal

    Input:
        msg: str -> Mensagem que será exibida ao usuário
        is_yes_or_no_question: bool -> Se a pergunta é de sim ou não

    Output:
        bool -> Resposta do usuário
    """
    resposta = input(msg)
    avaliacao: bool = True

    if is_yes_or_no_question:
        avaliacao = True if resposta.lower() == 's' else False

    os.system('clear')
    return avaliacao


def listar_restaurantes(opc: bool = True) -> None:
    """
    Função que lista os restaurantes cadastrados

    Input:
        opc: bool -> Se deve voltar ao menu principal
    """
    print_titulo_tela('Listando restaurantes')
    print('#'.ljust(3), '| NOME'.ljust(32), '| CATEGORIA'.ljust(22), '| STATUS')
    for index, restaurante in enumerate(restaurante_repo):
        status = 'ativo' if restaurante['ativo'] else 'desativado'

        print(
            f'{str(index + 1).ljust(3)} | {restaurante['nome'].ljust(30)} | {restaurante['categoria'].ljust(20)} | {status}'
        )
    if opc:
        voltar_menu_principal()


def alternar_status_restaurante() -> None:
    """
    Função que alterna o status do restaurante
    """
    print_titulo_tela('Alternando status do restaurante')

    listar_restaurantes(opc=False)
    index = (
        int(input('Digite o número do restaurante que deseja mudar o estado: '))
        - 1
    )
    restaurante = restaurante_repo[index]
    restaurante['ativo'] = not restaurante['ativo']
    msg_status = 'ativado' if restaurante['ativo'] else 'desativado'
    print(f'O restaurante {restaurante['nome']} foi {msg_status} com sucesso!')

    voltar_menu_principal()


if __name__ == '__main__':
    os.system('clear')
    while True:
        print_header()
        print_menu()
        opcao = get_opcao()
        executar_opcao(opcao)
