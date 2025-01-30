# 📌 Projeto Teste_DTI

Este é um sistema de lembretes desenvolvido como parte do processo de aprendizado e demonstração de habilidades de programação. Ele permite que os usuários adicionem, visualizem, atualizem e excluam lembretes de forma eficiente.

## 📌 Premissas

- Cada lembrete possui um nome e uma data de vencimento.
- Os lembretes podem ser marcados como "excluídos" (soft delete) sem serem removidos completamente do banco de dados.
- O banco de dados utilizado para armazenar os lembretes é o **MySQL**.

## ⚙️ Decisões de Projeto

- A aplicação é dividida em **backend** (API) e **frontend** (interface do usuário).
- O **backend** é desenvolvido com **C# e ASP.NET Core**, garantindo robustez e segurança.
- O **frontend** utiliza **Vue.js**, proporcionando uma interface dinâmica e reativa.
- A estrutura do banco de dados segue um modelo relacional baseado na classe `Reminder`.
- O projeto utiliza o **Git** para controle de versão e está hospedado no **GitHub**.

## 📌 Requisitos para Instalação

### 🔹 **Backend (.NET Core 7.0)**

O backend foi desenvolvido utilizando **.NET 7.0**, que **não possui mais suporte oficial**. Para rodá-lo corretamente, é necessário instalar o SDK correspondente:

🔗 [Baixar .NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

### 🔹 **Frontend (Vue.js)**

Para executar o frontend, é necessário instalar o **Node.js** na versão mais recente recomendada LTS:

🔗 [Baixar Node.js](https://nodejs.org)

## 🛠️ Configuração do Banco de Dados

1. Antes de executar a aplicação, é necessário criar o banco de dados. Utilize o arquivo [`dti-reminder-db.sql`](backend/Data/dti-reminder-db.sql) para configurar o MySQL.
2. Após a criação do banco de dados, atualize a string de conexão no arquivo [`appsettings.json`](backend/appsettings.json) dentro da pasta `backend` para que a API se conecte corretamente ao banco de dados.

## 🚀 Como Executar o Sistema

### 🔹 **Backend (.NET Core)**
```bash
cd backend
# Restaurar pacotes
  dotnet restore
# Executar a API
  dotnet run
```

### 🔹 **Frontend (Vue.js)**
```bash
cd frontend
# Instalar dependências
  npm install
# Iniciar servidor de desenvolvimento
  npm run serve
```

### 🔹 **Acesso ao Sistema**

- **Frontend Vue.js:** `http://localhost:8080`
- **Backend API:** `http://localhost:5193`
- **Swagger UI (documentação da API):** `http://localhost:5193/swagger/index.html`

## 🏗️ Estrutura do Projeto

```arduino
testedti/
├── backend/
│   ├── controllers/
│   │   └── ReminderApiController.cs
│   ├── data/
│   │   ├── ConnectionDbContext.cs
│   │   └── dti-reminder-db.sql
│   ├── models/
│   │   ├── Reminder.cs
│   │   └── ReminderGroup.cs
│   ├── properties/
│   │   └── launchsettings.json
│   ├── repositories/
│   │   ├── ReminderRepository.cs
│   │   └── Interfaces/
│   │       └── IReminderRepository.cs
│   ├── appsettings.json
│   ├── appsettings.development.json
│   ├── backend.csproj
│   ├── Program.cs
├── frontend/
│   ├── public/
│   │   ├── favicon.ico
│   │   └── index.html
│   ├── src/
│   │   ├── assets/
│   │   │   └── logo.png
│   │   ├── components/
│   │   │   ├── ReminderForm.vue
│   │   │   └── ReminderList.vue
│   │   ├── services/
│   │   │   ├── allReminderService.js
│   │   │   ├── reminderCreateService.js
│   │   │   ├── reminderDeleteService.js
│   │   │   ├── reminderEditService.js
│   │   │   └── reminderServiceById.js
│   │   ├── App.vue
│   │   ├── http-common.js
│   │   └── main.js
│   ├── babel.config.js
│   ├── jsconfig.json
│   ├── package-lock.json
│   ├── package.json
│   ├── vue.config.js
├── .gitignore
├── estrutura_projeto.txt
├── LICENSE
└── README.md
```

## 📚 Licença

Este projeto está licenciado sob a licença **MIT**. Consulte o arquivo [`LICENSE`](LICENSE) para obter mais detalhes.

