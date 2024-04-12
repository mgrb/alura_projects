from modelos.cardapio.bebida import Bebida
from modelos.cardapio.prato import Prato
from modelos.cardapio.sobremesa import Sobremesa
from modelos.restaurante import Restaurante

restaurante_praca = Restaurante('praça', 'Gourmet')


def montar_cardapio():
    restaurante_praca.adicionar_item_cardapio(
        Bebida('Suco de Laranja', 5.0, 300),
    )
    restaurante_praca.adicionar_item_cardapio(
        Prato('Feijoada', 20.0, 'Feijoada completa'),
    )

    prato_descontado = Prato('A Parmegiana', 20.0, 'Frango empanado + fritas')
    prato_descontado.aplicar_desconto()
    restaurante_praca.adicionar_item_cardapio(prato_descontado)

    sobremesa = Sobremesa('Pudim', 10.0, 'Doce de leite', '200g')
    sobremesa.aplicar_desconto()
    restaurante_praca.adicionar_item_cardapio(sobremesa)
    sobremesa_grande = Sobremesa('Pudim', 10.0, 'Doce de leite', '500g')
    restaurante_praca.adicionar_item_cardapio(sobremesa_grande)


def main():
    montar_cardapio()
    restaurante_praca.listar_cardapio


if __name__ == '__main__':
    main()
