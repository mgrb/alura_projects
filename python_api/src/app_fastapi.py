"""REST API with FastAPI."""

from contextlib import asynccontextmanager

import uvicorn
from fastapi import FastAPI, status
from fastapi.middleware.cors import CORSMiddleware
from requests import get

from exception.ext_api_error import ExtAPIError


def load_restaurantes_data() -> dict:
    """Load restaurantes data from API."""
    url = (
        'https://guilhermeonrails.github.io/api-restaurantes/restaurantes.json'
    )
    response = get(url, timeout=60)
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

origins = ['http://localhost', 'http://localhost:8888']

app.add_middleware(
    CORSMiddleware,
    allow_origins=origins,
    allow_credentials=True,
    allow_methods=['*'],
    allow_headers=['*'],
)


@app.get('/')
def read_root() -> dict:
    """Root endpoint."""
    return {'Hello': 'World'}


@app.get('/api/restaurantes')
async def read_restaurantes(name: str = None) -> dict:
    """Get restaurantes data."""
    return_data = {}
    if not name:
        return_data = {'Dados': restaurantes_cardapio}
    elif (name not in restaurantes_cardapio) or (
        not restaurantes_cardapio[name]
    ):
        return_data = {'message': 'Restaurante não encontrado'}
    else:
        return_data = {'Dados': restaurantes_cardapio.get(name)}

    return return_data


if __name__ == '__main__':
    uvicorn.run('app_fastapi:app', host='localhost', port=8888, reload=True)
