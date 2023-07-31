# Projeto testedti

Este é um projeto de sistema de lembretes desenvolvido como parte do processo de aprendizado e demonstração de habilidades de programação.

## Premissas

- O sistema de lembretes é uma aplicação web que permite adicionar, visualizar, atualizar e excluir lembretes.
- Os lembretes consistem em um nome e uma data de vencimento.
- Os lembretes podem ser marcados como "excluídos" (soft delete) sem serem removidos completamente do banco de dados.
- O sistema utiliza o banco de dados MySQL para armazenar os lembretes.

## Decisões de Projeto

- O sistema é dividido em duas partes principais: o backend (API) e o frontend (Vue.js).
- A API é construída com C# usando o ASP.NET Core, e o frontend é desenvolvido com Vue.js.
- A estrutura do banco de dados segue o modelo definido na classe `Reminder`.
- Para o controle de versão, o projeto utiliza o Git e está hospedado no GitHub.

## Instruções para Configuração do Banco de Dados

1. Antes de executar a aplicação, é necessário criar o banco de dados. Utilize o arquivo [dtiReminderDB.sql](backend/Data/dtiReminderDB.sql)
 fornecido para criar o banco de dados no MySQL.

2. Após a criação do banco de dados, atualize a string de conexão no arquivo [appsettings.json](backend/appsettings.json) dentro da pasta backend para que a API se conecte ao banco de dados corretamente.

## Instruções para Executar o Sistema


1. Certifique-se de ter o .NET Core SDK e o Node.js instalados em sua máquina.
2. Clone este repositório para o seu ambiente de desenvolvimento local.
3. Navegue para a pasta do projeto backend:

```bash
cd backend
```

4. Restaure as dependências e execute a API:

```bash
dotnet restore
dotnet run
```

5. Em outro terminal, navegue para a pasta do projeto frontend:

```bash
cd frontend
```

6. Restaure as dependências e execute o frontend:

```bash
npm install
npm run serve
```

7. O sistema estará disponível em http://localhost:8080/ e a API em http://localhost:5193/.


## Documentação da API

A API possui uma documentação interativa gerada pelo Swagger, que facilita a visualização dos endpoints disponíveis, seus parâmetros e respostas. Para acessar a documentação, basta utilizar o Swagger UI através da seguinte URL:

http://localhost:5193/swagger/index.html

## Estrutura do Projeto

```arduino
testedti/
├── backend/
│   ├── Controllers/
│   ├── Data/
│   ├── Models/
│   ├── Repository/
│   │   └── Interfaces/
│   └── appsettings.json
├── frontend/
│   ├── public/
│   ├── src/
│   │   ├── assets/
│   │   ├── components/
│   │   ├── Services/
│   │   ├── App.vue
│   │   ├── http-common.js
│   │   └── main.js
│   ├── babel.config.js
│   ├── package.json
│   └── vue.config.js
├── LICENSE
└── README.md
```

## Licença
Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para obter mais detalhes.
