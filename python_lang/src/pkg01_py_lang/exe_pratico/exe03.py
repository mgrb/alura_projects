"""
Implementação do Exe 03 do curso.
"""

"""
1 - Crie uma lista para cada informação a seguir:
- Lista de números de 1 a 10;
- Lista com quatro nomes;
- Lista com o ano que você nasceu e o ano atual.
"""
from datetime import datetime

print('Exercício 1')
numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
nomes = ['Lucas', 'Pedro', 'João', 'Maria']
anos = list(range(1983, datetime.now().year))
print(numeros)
print(nomes)
print(anos)
print('----------------------------------------')

"""
2 - Crie uma lista e utilize um loop for para percorrer todos os elementos da 
lista.
"""
print('Exercício 2')
lista = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j']
for item in lista:
    print(item)
print('----------------------------------------')

"""
3 - Utilize um loop for para calcular a soma dos números ímpares de 1 a 10.
"""
print('Exercício 3')
soma = 0
for num in range(1, 11):
    if num % 2 != 0:
        soma += num
print(soma)
print('----------------------------------------')

"""
4 - Utilize um loop for para imprimir os números de 1 a 10 em ordem decrescente.
"""
print('Exercício 4')
for num in range(10, 0, -1):
    print(num)
print('----------------------------------------')

"""
5 - Solicite ao usuário um número e, em seguida, utilize um loop for para 
imprimir a tabuada desse número, indo de 1 a 10.
"""
print('Exercício 5')
numero = int(input('Digite um número: '))
for num in range(1, 11):
    print(f'{numero} x {num} = {numero * num}')
print('----------------------------------------')

"""
6 - Crie uma lista de números e utilize um loop for para calcular a soma de 
todos os elementos. Utilize um bloco try-except para lidar com possíveis 
exceções.
"""
print('Exercício 6')
soma = 0
lista = [1, 2, 3, 4, None, 6, '7', 8, 9, 10]
for item in lista:
    try:
        soma += item
    except ValueError:
        continue
    except TypeError:
        continue
print(soma)
print('----------------------------------------')

"""
7 - Construa um código que calcule a média dos valores em uma lista. Utilize um 
bloco try-except para lidar com a divisão por zero, caso a lista esteja vazia.
"""
print('Exercício 7')
lista = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
try:
    media = sum(lista) / len(lista)
except ZeroDivisionError:
    print('A lista está vazia.')
print(media)
print('----------------------------------------')
