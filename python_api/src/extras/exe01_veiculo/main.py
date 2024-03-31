from carro import Carro
from moto import Moto

if __name__ == '__main__':
    carro_01 = Carro('Chevy', 'S10', 4)
    carro_02 = Carro('Ford', 'Ranger', 4)
    carro_03 = Carro('Fiat', 'Strada', 2)
    carro_04 = Carro('VW', 'Saveiro', 2)

    moto_01 = Moto('Honda', 'CB500', 'Casual')
    moto_02 = Moto('Yamaha', 'MT-07', 'Sport')
    moto_03 = Moto('Suzuki', 'GSX-S750', 'Sport')

    veiculos = [
        carro_01,
        carro_02,
        carro_03,
        carro_04,
        moto_01,
        moto_02,
        moto_03,
    ]

    for veiculo in veiculos:
        print(veiculo)

    carro_01.ligar()
    carro_03.ligar()
    moto_03.ligar()
