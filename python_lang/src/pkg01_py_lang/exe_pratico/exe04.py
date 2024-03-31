"""
Pratica com dicionarios
"""

"""
1 - Crie um dicionário representando informações sobre uma pessoa, como nome, idade e cidade.
"""
print('Exercício 1')
pessoa = {'nome': 'João', 'idade': 25, 'cidade': 'São Paulo'}
print(pessoa)

"""
2 - Utilizando o dicionário criado no item 1:
    - Modifique o valor de um dos itens no dicionário (por exemplo, atualize a idade da pessoa);
    - Adicione um campo de profissão para essa pessoa;
    - Remova um item do dicionário.
"""
print('Exercício 2')
pessoa['idade'] = 26
pessoa['profissao'] = 'Desenvolvedor'
pessoa.pop('cidade')

print(pessoa)

"""
3 - Crie um dicionário utilizando para representar números e seus quadrados de 1 a 5.
"""
print('Exercício 3')
numeros_quadrados = {
    num: num**2 for num in range(1, 6)
}  # {1: 1, 2: 4, 3: 9, 4: 16, 5: 25}
print(numeros_quadrados)

"""
4 - Crie um dicionário e verifique se uma chave específica existe dentro desse dicionário.
"""
print('Exercício 4')
dicionario = {'a': 1, 'b': 2, 'c': 3}
print('a' in dicionario)  # True
print('d' in dicionario)  # False

"""
5 - Escreva um código que conte a frequência de cada palavra em uma frase utilizando um dicionário.
"""
print('Exercício 5')
frase = 'o rato roeu a roupa do rei de roma e a rainha ficou nua e o rei também'
palavras = frase.split()
frequencia = {}
for palavra in palavras:
    if palavra in frequencia:
        frequencia[palavra] += 1
    else:
        frequencia[palavra] = 1

print(f'Frase: {frase}')
print(f'Frequência das palavras: {frequencia}')
