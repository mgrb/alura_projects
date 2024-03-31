from modelos.restaurante import Restaurante


def main() -> None:
    restaurante: Restaurante = Restaurante('Pizzaria do Python', 'Pizzaria')
    restaurante.receber_avaliacao('Alice', 9.5)
    restaurante.receber_avaliacao('Bob', 8.5)
    restaurante.receber_avaliacao('Charlie', 7.3)
    restaurante.receber_avaliacao('David', 6.1)

    restaurante.listar_restaurantes()


if __name__ == '__main__':
    main()
