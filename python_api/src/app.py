from modelos.cardapio.bebida import Bebida
from modelos.cardapio.prato import Prato
from modelos.restaurante import Restaurante

restaurante_praca = Restaurante('praça', 'Gourmet')
bebida_suco = Bebida('Suco de Laranja', 5.0, 300)
prato_feijoada = Prato('Feijoada', 20.0, 'Feijoada completa')


def main():
    print(bebida_suco)
    print(prato_feijoada)


if __name__ == '__main__':
    main()
