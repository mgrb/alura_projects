"""Aplicação de request.

Este módulo é responsável por fazer requisições HTTP para a API de
restaurantes.
"""

import json
from pathlib import Path

import requests

restaurantes_url = (
    'https://guilhermeonrails.github.io/api-restaurantes/restaurantes.json'
)

response = requests.get(restaurantes_url, timeout=10)

dados_restaurante = {}

if response.status_code == 200:
    response_json = response.json()
    for restaurante in response_json:
        nome_restaurante = restaurante['Company']
        if nome_restaurante not in dados_restaurante:
            dados_restaurante[nome_restaurante] = []

        dados_restaurante[nome_restaurante].append(
            {
                'item': restaurante['Item'],
                'price': restaurante['price'],
                'description': restaurante['description'],
            },
        )
else:
    print(f'Erro ao fazer requisição: {response.status_code}')

for nome_restaurante, dados in dados_restaurante.items():
    nome_arquivo = f'{nome_restaurante}.json'
    with Path.open('outdata/' + nome_arquivo, 'w') as arquivo:
        json.dump(dados, arquivo, indent=4)
