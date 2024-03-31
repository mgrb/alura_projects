"""
Implementação do exercício 02 do curso de Python da Alura.
CURSO: Paython: crie a sua primeira aplicação.
"""

import os

def executar_modulo_impar_ou_par():
    numero = int(input('Digite um número: '))
    if numero % 2 == 0:
        print(f'O número {numero} é par.')
    else:
        print(f'O número {numero} é ímpar.')

def executar_modulo_faixa_etaria():
    idade = int(input('Digite a sua idade: '))
    if idade >= 0 and idade <= 12:
        print('Você é uma criança.')
    elif idade >= 13 and idade <= 18:
        print('Você é um adolescente.')
    elif idade >= 19:
        print('Você é um adulto.')
    else:
        print('Idade invalida.')

def executar_modulo_autenticacao():
    usuario = input('Digite o seu usuário: ')
    senha = input('Digite a sua senha: ')
    if usuario == 'aluno' and senha == '123':
        print('Usuário autenticado.')
    else:
        print('Usuário não autenticado.')

def executar_modulo_plano_cartesiano():
    x = int(input('Digite o valor de x: '))
    y = int(input('Digite o valor de y: '))
    if x > 0 and y > 0:
        print('O ponto está no primeiro quadrante.')
    elif x < 0 and y > 0:
        print('O ponto está no segundo quadrante.')
    elif x < 0 and y < 0:
        print('O ponto está no terceiro quadrante.')
    elif x > 0 and y < 0:
        print('O ponto está no quarto quadrante.')
    else:
        print('O ponto está na origem.')

def print_header():
    print('Exercício 02 - Curso de Python da Alura')
    print('----------------------------------------')

def print_divisor():
    print('========================================')

def encerrar_script():
    print('Fim do script.')
    input('Pressione ENTER para encerrar...')

if __name__ == '__main__':
    os.system('clear')
    print_header()
    executar_modulo_impar_ou_par()
    print_divisor()
    executar_modulo_faixa_etaria()
    print_divisor()
    executar_modulo_autenticacao()
    print_divisor()
    executar_modulo_plano_cartesiano()
    print_divisor()
    encerrar_script()
    os.system('clear')

