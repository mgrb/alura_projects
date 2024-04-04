"""REST API with FastAPI."""

from contextlib import asynccontextmanager

import uvicorn
from fastapi import FastAPI, status
from requests import get

from exception.ext_api_error import ExtAPIError


def load_restaurantes_data() -> dict:
    """Load restaurantes data from API."""
    url = (
        'https://guilhermeonrails.github.io/api-restaurantes/restaurantes.json'
    )
    response = get(url, timeout=10)
    restaurantes_data: dict = {}
    if response.status_code == status.HTTP_200_OK:
        response_json = response.json()
        restaurantes_data = extract_restaurantes_data(response_json)
    else:
        raise ExtAPIError(response.status_code, response.reason)

    return restaurantes_data


def extract_restaurantes_data(data: list) -> dict:
    """Extract restaurantes data from API response."""
    restaurantes_data = {}
    for restaurante in data:
        if restaurante['Company'] not in restaurantes_data:
            restaurantes_data[restaurante['Company']] = {'Cardapio': []}

        restaurantes_data[restaurante['Company']]['Cardapio'].append(
            {
                'item': restaurante['Item'],
                'price': restaurante['price'],
                'description': restaurante['description'],
            },
        )
    return restaurantes_data


restaurantes_cardapio = {}


@asynccontextmanager
async def life_span(app: FastAPI) -> any:  # noqa: ARG001
    """Load and clean up restaurantes data."""
    print('Starting application')
    restaurantes_cardapio.update(load_restaurantes_data())
    print(
        f'Restaurantes data loaded. {len(restaurantes_cardapio)} restaurantes.',
    )
    yield
    print('Stopping application')
    restaurantes_cardapio.clear()


app = FastAPI(lifespan=life_span)


@app.get('/')
def read_root() -> dict:
    """Root endpoint."""
    return {'Hello': 'World'}


@app.get('/api/restaurantes')
async def read_restaurantes(name: str = None) -> dict:
    """Get restaurantes data."""
    if not name:
        return restaurantes_cardapio

    if (name not in restaurantes_cardapio) or (not restaurantes_cardapio[name]):
        return {'message': 'Restaurante não encontrado'}

    return {'Dados': restaurantes_cardapio.get(name)}


if __name__ == '__main__':
    uvicorn.run('app_fastapi:app', host='localhost', port=8888, reload=True)
