# 📚 Biblioteca Web API

![2025-11-17 21-38-42](https://github.com/user-attachments/assets/385b938e-5f74-4189-ad3a-9b7eba5e4f74)

## 🧩 Descrição do Projeto

A **Biblioteca Web API** é um projeto desenvolvido em **.NET 8** com o objetivo de gerenciar informações de **autores** e **livros**.  
A aplicação segue os princípios de uma **API RESTful**, permitindo realizar operações **CRUD** (Create, Read, Update, Delete) sobre as entidades **Autor** e **Livro**, com persistência dos dados em um banco **SQL Server**. <br>
📚 **O que foi desenvolvido:**

- CRUD completo de Autores

- CRUD completo de Livros

- Relacionamento entre Autores e Livros

- Uso de DTOs para padronização da transferência de dados

- Arquitetura organizada em Controllers, Services e Repository

- Documentação da API com Swagger/OpenAPI

- Banco de dados configurado com Entity Framework + SQL Server

- Injeção de dependência configurada em toda a aplicação

---

## 🛠 Tecnologias Utilizadas

- **.NET 8 Web API**
- **C#**
- **SQL Server**
- **Entity Framework Core 8**
- **Swagger**

---

## 📁 Estrutura do Projeto

```text
Biblioteca_Api/
├── 📂 Controllers/
│   ├── AutorController.cs
│   └── LivroController.cs
├── 📂 Models/
│   ├── AutorModel.cs
│   └── LivroModel.cs
├── 📂 Dto/
│   ├── Autor/
│   │   ├── AutorCriacaoDto.cs
│   │   └── AutorEdicaoDto.cs
│   └── Livro/
│       ├── LivroCriacaoDto.cs
│       └── LivroEdicaoDto.cs
├── 📂 Services/
│   ├── Autor/
│   │   ├── IAutorInterface.cs
│   │   └── AutorService.cs
│   └── Livro/
│       ├── ILivroInterface.cs
│       └── LivroService.cs
├── 📂 Data/
│   └── AppDbContext.cs
├── 📂 Migrations/
├── appsettings.json
└── Program.cs
```

---

## 🧠 Endpoints Disponíveis

<img width="1339" height="352" alt="{0F03DE42-5479-41D6-A11F-1F5E48C35F48}" src="https://github.com/user-attachments/assets/00fd9768-5b90-4d8b-b7d8-8027e2b125b4" />
<img width="1325" height="347" alt="{402B43AE-007B-4D21-BF74-AF93EA0364A3}" src="https://github.com/user-attachments/assets/597cec5f-96b9-4d3b-a1c4-430d283a685f" />


---

## 🧾 Licença

Este projeto é de uso livre para fins de estudo e aprendizado.<br>
Sinta-se à vontade para clonar, modificar e expandir conforme necessário.

---

## 👩‍💻 Desenvolvido por Daliene Nonato Lima Roque
Agradecimento especial:
Quero reconhecer e agradecer à professora Crislaine D'Paula, cuja didática e apoio foram fundamentais para a construção deste projeto. Sua orientação foi essencial para o meu aprendizado e progresso.

### 📫 Contato:


[![GitHub](https://img.shields.io/badge/GitHub-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/DalieneRoque)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/daliene-nonato-lima-roque-a5b167269/)

