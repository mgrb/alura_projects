FROM nginx

COPY nginx.conf /etc/nginx/conf.d/alura_plus-webpage.conf

WORKDIR /alura_plus-webpage

COPY ./page .

EXPOSE 80

CMD [ "nginx", "-g", "daemon off;"]