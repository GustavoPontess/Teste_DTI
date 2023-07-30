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

7. O sistema estará disponível em http://localhost:8080/ e a API em http://localhost:5000/.

## Estrutura do Projeto

```arduino
meu-projeto/
├── backend/
│   ├── Controllers/
│   ├── Models/
│   ├── Services/
│   ├── Data/
│   └── appsettings.json
├── frontend/
│   ├── public/
│   ├── src/
│   │   ├── assets/
│   │   ├── components/
│   │   ├── views/
│   │   ├── api.js
│   │   └── main.js
│   ├── babel.config.js
│   ├── package.json
│   └── vue.config.js
├── LICENSE
└── README.md
```

## Licença
Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para obter mais detalhes.
