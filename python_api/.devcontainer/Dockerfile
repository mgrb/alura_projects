FROM python:3.12-alpine

RUN apk update && apk add --no-cache \
git \
curl \
zsh \
starship \
openssh \
pipx \
make \
&& adduser -D -s /bin/zsh -u 1000 alura-usr 

USER alura-usr

ENV PATH="/home/alura-usr/.local/bin:${PATH}"
ENV ZSH_THEME starship

COPY .zshrc /home/alura-usr

SHELL ["/bin/zsh", "-c"]

RUN pipx install poetry --python $(which python) \
&& poetry config virtualenvs.create true \
&& poetry config virtualenvs.prefer-active-python true \
&& poetry config virtualenvs.in-project true


WORKDIR /workspace
COPY ../ .


CMD ["tail", "-f", "/dev/null"]