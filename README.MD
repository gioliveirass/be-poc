# Back-end POC TMB

O presente repositório contém o codigo do back-end desenvolvido para POC da TMB 🚀

## Tecnologias utilizadas

- C#
- Entity Framework
- MySql

## Requisitos

Para executar o projeto em seu computador, você precisa ter instalado:

- DOTNET versão 8.0.409
- Docker (recomendado)

Além do mais, é necessário configurar o banco de dados MySql e ajustar as configurações de autenticação localizadas no atributo "AppDbConnectionString" do arquivo "appsettings.json".

Alternativamente, você pode utilizar o arquivo "docker-compose.yml" para levantar um container do docker contendo o banco de dados já com as configurações de autenticação default definidas no arquivo "appsettings.json".

## Instalação

Para executar o projeto em sua máquina, primeiro realize a configuração do banco de dados. Se optar por utilizar o docker-compose, execute os seguintes comandos na raiz do projeto clonado:

```bash
  docker-compose up -d
  docker exec -it mysql bash
  mysql -u root -p
  update mysql.user set host='%' where user='root';
  FLUSH PRIVILEGES;
```

Após isso, ainda na raiz do projeto, execute os comandos:

```bash
    dotnet ef database update
    dotnet build
    dotnet run
```

O projeto será inicializado em http://localhost:5163/. Também é possível verificar a documentação swagger em http://localhost:5163/swagger/index.html.
