# PYTHON
Crie a sua primeira aplicação

Este repositório é destinado para realização dos projetos e exercícios sugeridos no curso de Python da Alura.

## Projeto principal
Desenvolver um script de gerenciamento de catalogo de restaurantes simulando um iFood.

### Para executar o projeto
```
$> python src/app.py
```

## Exercícios
Varios exercicios para praticar estutura da linguagem Python e aprimorar conceitos e caractaristicas da mesma.

Os exercícios estão divididos em arquivos que foram criados a medida que as sugestões de práticas foram aparecendo no decorrer do curso.
Cada arquivo é autocontdo e representa um script a q pode ser executado.

Ex.:
```
$> python src/bonus/exe01.py
```

## O Ambiente de Desenvolvimento
Este repositório esta organizando em um devcontainer. 
E para instacia-lo no VSCODE é recomendado as seguintes configurações:

### Extenções recomendadas

- Name: Remote Development
- Id: ms-vscode-remote.vscode-remote-extensionpack
- Description: An extension pack that lets you open any folder in a container, on a remote machine, or in WSL and take advantage of VS Code's full feature set.
- Version: 0.25.0
- Publisher: Microsoft
- VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.vscode-remote-extensionpack

### Docker Engine

É obrigatório ter o Docker Engine já instalado e cunfigurado. Para mais informações de como instalar o Docker Engine em seu SO, ver em:

- Instruções para instalação do Docker Engine: [Ver o link](https://docs.docker.com/engine/install/)

### Procedimento para instanciar o projeto no VSCODE
1. Com o pack de extenções instalado,
1. Realize o clone/fork deste repositório,
1. Abra o diretorio deste repositorio no VSCODE como um projeto,
1. Use o Comando _Dev Containers: Reopen in Container_ da paleta de comandos do VSCODE. _(F1, Ctrl+Shift+P)_.

Depois da compilação do conatainer o VSCode abrirá o repositório em um ambiente encapsulado e executando diretamente de dentro do container como configurado nas definições do **/.devconainer**.


