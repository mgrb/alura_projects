SHEll := /bin/zsh
.PHONY: venv install

venv:
	@poetry shell -n

install:
	@poetry install

start_app:
	@python /workspace/src/app_fastapi.py