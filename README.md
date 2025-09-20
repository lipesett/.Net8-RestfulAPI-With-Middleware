# Task Manager RESTful API - .NET 8 Portfolio

![.NET](https://img.shields.io/badge/.NET-8-blueviolet) ![C#](https://img.shields.io/badge/C%23-11-blue) ![SQLite](https://img.shields.io/badge/SQLite-3-blue) ![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-orange) ![SOLID Principles](https://img.shields.io/badge/SOLID-Principles-brightgreen)

This repository contains a complete RESTful API for a task manager, developed with .NET 8 and C# 11. The project was built from scratch with the goal of demonstrating development best practices, including Clean Architecture, SOLID principles, and robust error handling.

## 🚀 Concepts and Technologies Applied

This project serves as a practical demonstration of the following concepts and technologies:

* **.NET 8 & ASP.NET Core:** Utilization of Microsoft's latest framework for building high-performance APIs.
* **Clean Architecture:** The project structure is divided into layers of responsibility (Controller, Service, Repository), promoting low coupling and high testability.
* **SOLID Principles:** The code's design adheres to SOLID principles to create more maintainable and extensible software.
* **Entity Framework Core 8:** Object-Relational Mapper (ORM) for interacting with the database efficiently.
* **SQLite:** A lightweight, file-based database, ideal for local development and portability.
* **Repository Pattern:** Abstraction of the data access layer to decouple business logic from the persistence technology.
* **Dependency Injection (DI):** Extensive use of the native DI container in ASP.NET Core to manage the services' lifecycle.
* **DTOs (Data Transfer Objects):** Use of DTOs to create a public "contract" for the API, decoupling the API models from the database data models.
* **AutoMapper:** A library to facilitate the mapping between entities and DTOs automatically and configurably.
* **Global Error Handling with Middleware:** Implementation of a centralized middleware to catch custom exceptions (`NotFoundException`, `BadRequestException`) and return standardized and informative HTTP error responses.
* **Swagger/OpenAPI:** API documentation is automatically generated to facilitate testing and integration.

## 📋 API Endpoints

The API exposes the following endpoints for CRUD operations on tasks:

| Verb     | Route               | Description                    |
| :------- | :------------------ | :----------------------------- |
| `GET`    | `/api/Tasks`        | Lists all tasks.               |
| `GET`    | `/api/Tasks/{id}`   | Fetches a specific task by ID. |
| `POST`   | `/api/Tasks`        | Creates a new task.            |
| `PUT`    | `/api/Tasks/{id}`   | Updates an existing task.      |
| `DELETE` | `/api/Tasks/{id}`   | Deletes a task.                |

## ⚙️ How to Run the Project

To run this project locally, follow the steps below:

### Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Git

### Steps

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/SEU-USUARIO/.Net8-RestfulAPI-With-Middleware.git](https://github.com/SEU-USUARIO/.Net8-RestfulAPI-With-Middleware.git)
    ```
    (Remember to replace `SEU-USUARIO` with your GitHub username)

2.  **Navigate to the project folder:**
    ```bash
    cd .Net8-RestfulAPI-With-Middleware/TaskManagerApi
    ```

3.  **Prepare the Database (First time only):**
    This command creates the `tasks.db` database file. The command you use depends on your terminal.

    * **If you are using a standard terminal (Git Bash, PowerShell, CMD):**
        First, you may need to install the EF Core global tool (you only need to do this once per machine):
        ```bash
        dotnet tool install --global dotnet-ef
        ```
        Then, run the update command:
        ```bash
        dotnet ef database update
        ```

    * **If you are using the Visual Studio Package Manager Console (PMC):**
        Simply run the command:
        ```powershell
        Update-Database
        ```

4.  **Run the Application:**
    This is the command you will use daily to start the API server.
    ```bash
    dotnet run
    ```

5.  **Access the Swagger documentation:**
    The API will be running locally. Open your browser and navigate to the application URL indicated in the terminal (usually `https://localhost:7XXX/swagger`) to see the interactive documentation and test the endpoints.

---
---

# API RESTful de Gerenciador de Tarefas - Portfólio .NET 8

![.NET](https://img.shields.io/badge/.NET-8-blueviolet) ![C#](https://img.shields.io/badge/C%23-11-blue) ![SQLite](https://img.shields.io/badge/SQLite-3-blue) ![Arquitetura Limpa](https://img.shields.io/badge/Arquitetura-Limpa-orange) ![Princípios SOLID](https://img.shields.io/badge/Princípios-SOLID-brightgreen)

Este repositório contém uma API RESTful completa para um gerenciador de tarefas, desenvolvida com .NET 8 e C# 11. O projeto foi construído do zero com o objetivo de demonstrar as melhores práticas de desenvolvimento, incluindo Arquitetura Limpa (Clean Architecture), princípios SOLID e tratamento de erros robusto.

## 🚀 Conceitos e Tecnologias Aplicadas

Este projeto serve como uma demonstração prática dos seguintes conceitos e tecnologias:

* **.NET 8 & ASP.NET Core:** Utilização do framework mais recente da Microsoft para a construção de APIs de alta performance.
* **Arquitetura Limpa (Clean Architecture):** A estrutura do projeto é dividida em camadas de responsabilidade (Controller, Service, Repository), promovendo baixo acoplamento e alta testabilidade.
* **Princípios SOLID:** O design do código segue os princípios SOLID para criar um software mais manutenível e extensível.
* **Entity Framework Core 8:** Mapeamento objeto-relacional (ORM) para interagir com o banco de dados de forma eficiente.
* **SQLite:** Banco de dados leve e baseado em arquivo, ideal para desenvolvimento local e portabilidade.
* **Padrão de Repositório (Repository Pattern):** Abstração da camada de acesso a dados para desacoplar a lógica de negócio da tecnologia de persistência.
* **Injeção de Dependência (Dependency Injection):** Uso extensivo do container de DI nativo do ASP.NET Core para gerenciar o ciclo de vida dos serviços.
* **DTOs (Data Transfer Objects):** Utilização de DTOs para criar um "contrato" público para a API, desacoplando os modelos da API dos modelos de dados do banco.
* **AutoMapper:** Biblioteca para facilitar o mapeamento entre entidades e DTOs de forma automática e configurável.
* **Tratamento de Erros Global com Middleware:** Implementação de um middleware centralizado para capturar exceções customizadas (`NotFoundException`, `BadRequestException`) e retornar respostas de erro HTTP padronizadas e informativas.
* **Swagger/OpenAPI:** Documentação da API gerada automaticamente para facilitar o teste e a integração.

## 📋 Endpoints da API

A API expõe os seguintes endpoints para operações CRUD em tarefas:

| Verbo    | Rota                | Descrição                           |
| :------- | :------------------ | :---------------------------------- |
| `GET`    | `/api/Tasks`        | Lista todas as tarefas.             |
| `GET`    | `/api/Tasks/{id}`   | Busca uma tarefa específica por ID. |
| `POST`   | `/api/Tasks`        | Cria uma nova tarefa.               |
| `PUT`    | `/api/Tasks/{id}`   | Atualiza uma tarefa existente.      |
| `DELETE` | `/api/Tasks/{id}`   | Exclui uma tarefa.                  |

## ⚙️ Como Executar o Projeto

Para executar este projeto localmente, siga os passos abaixo:

### Pré-requisitos
* [.NET 8 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
* Git

### Passos

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/SEU-USUARIO/.Net8-RestfulAPI-With-Middleware.git](https://github.com/SEU-USUARIO/.Net8-RestfulAPI-With-Middleware.git)
    ```
    (Lembre-se de substituir `SEU-USUARIO` pelo seu nome de usuário do GitHub)

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd .Net8-RestfulAPI-With-Middleware/TaskManagerApi
    ```

3.  **Prepare o Banco de Dados (Apenas na primeira vez):**
    Este comando cria o arquivo de banco de dados `tasks.db`. O comando a ser usado depende do seu terminal.

    * **Se você estiver usando um terminal padrão (Git Bash, PowerShell, CMD):**
        Primeiro, pode ser necessário instalar a ferramenta global do EF Core (você só precisa fazer isso uma vez por máquina):
        ```bash
        dotnet tool install --global dotnet-ef
        ```
        Em seguida, execute o comando de atualização:
        ```bash
        dotnet ef database update
        ```

    * **Se você estiver usando o Package Manager Console (PMC) do Visual Studio:**
        Simplesmente execute o comando:
        ```powershell
        Update-Database
        ```

4.  **Execute a Aplicação:**
    Este é o comando que você usará no dia a dia para iniciar o servidor da API.
    ```bash
    dotnet run
    ```

5.  **Acesse a documentação do Swagger:**
    A API estará rodando localmente. Abra seu navegador e acesse a URL indicada no terminal (geralmente `https://localhost:7XXX/swagger`) para ver a documentação interativa e testar os endpoints.
