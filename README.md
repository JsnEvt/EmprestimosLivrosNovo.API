# 📚 Livraria Controle de Empréstimo — Projeto CAFÉ COM BUG ☕

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Language-239120?logo=c-sharp&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-API%20Docs-brightgreen?logo=swagger)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-5C2D91?logo=entity-framework&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-yellow)
![Architecture](https://img.shields.io/badge/Architecture-RESTful%20API-orange)
![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-informational)

---

## ☕ Sobre o Projeto

Este projeto faz parte da série **Café com Bug** no YouTube e tem como objetivo demonstrar a criação de uma **API RESTful completa para controle de empréstimos de livros**, utilizando **arquitetura em camadas** e **boas práticas de desenvolvimento em .NET**.

O projeto enfatiza **organização, desacoplamento e testabilidade**, sendo um excelente exemplo de **Clean Architecture aplicada a APIs RESTful**.

---

## 🏗️ Estrutura da Solução

A solução segue uma arquitetura modular e escalável, composta por **5 projetos principais**:

📁 LivrariaControleEmprestimo  
│  
├── 📦 LivrariaControleEmprestimo.API  
├── 📦 LivrariaControleEmprestimo.Application  
├── 📦 LivrariaControleEmprestimo.Domain  
├── 📦 LivrariaControleEmprestimo.Infra.Data  
└── 📦 LivrariaControleEmprestimo.Infra.IoC  


---

## 🔍 Finalidade de Cada Projeto

### **1️⃣ LivrariaControleEmprestimo.API**
- Responsável por **expor os endpoints HTTP**.
- Contém os **controllers** e a configuração do **Swagger**.
- Gerencia o **pipeline de execução** (rotas, middlewares, injeções, etc.).

### **2️⃣ LivrariaControleEmprestimo.Application**
- Centraliza as **regras de negócio e casos de uso**.
- Contém os **serviços (Services)** e **DTOs**.
- Faz a ponte entre o **Domain** e a **API**.

### **3️⃣ LivrariaControleEmprestimo.Domain**
- Núcleo da aplicação (**entidades**, **interfaces**, **regras de negócio puras**).
- Independente de frameworks e infraestrutura.

### **4️⃣ LivrariaControleEmprestimo.Infra.Data**
- Implementa os **repositórios** e o **contexto do Entity Framework Core**.
- Responsável pela **persistência e acesso a dados**.

### **5️⃣ LivrariaControleEmprestimo.Infra.IoC**
- Realiza o **registro das dependências** (injeção de dependência).
- Facilita a **configuração e manutenção** do projeto.

---

## 🧠 Fluxo da Aplicação (RESTful)

1. O cliente realiza uma **requisição HTTP** à API.  
2. O **Controller** repassa o processamento à camada **Application**.  
3. A **Application** aplica as regras e chama os **Repositórios**.  
4. O **Infra.Data** executa a operação no banco de dados via **Entity Framework Core**.  
5. A resposta é retornada ao cliente no formato **JSON**.  

---

## 🌐 Arquitetura REST x MVC

Este projeto **não utiliza o padrão MVC tradicional**, e sim uma **arquitetura RESTful**, ideal para **serviços modernos e integrações** com front-ends independentes (como React, Angular, Vue ou mobile apps).

| Aspecto | **Arquitetura REST (API)** | **Arquitetura MVC (Web App)** |
|----------|-----------------------------|-------------------------------|
| **Finalidade** | Expor endpoints para comunicação entre sistemas (APIs). | Renderizar páginas HTML para o usuário final. |
| **Camadas** | API → Application → Domain → Infra.Data → Infra.IoC | Controller → View → Model |
| **Retorno** | Dados em **JSON** | Páginas **HTML/Razor** |
| **Front-end** | Externo (SPA, mobile, etc.) | Integrado na mesma aplicação |
| **Uso típico** | Microsserviços, integrações, backends independentes | Aplicações web monolíticas |

➡️ **Em resumo:**  
Este é um projeto **API RESTful** voltado ao **gerenciamento de empréstimos de livros**, enquanto o padrão **MVC** se aplica a **aplicações web visuais**.

---

## 🚀 Swagger — Documentação Interativa

O projeto utiliza o **Swagger** para documentar, visualizar e testar os endpoints da API.

### 🔧 Como acessar
Após executar o projeto **EmprestimosLivrosNovo.API**, abra no navegador:


> Você verá a interface do Swagger com todos os endpoints, podendo testar as operações diretamente do navegador.

---

## 🧩 Tecnologias Utilizadas

- 🟣 **.NET 8 (ou superior)**
- 🧱 **Entity Framework Core**
- 🗄️ **SQL Server**
- ⚙️ **Dependency Injection (IoC)**
- 🧭 **AutoMapper** *(se utilizado)*
- 📗 **Swagger / Swashbuckle**
- 💬 **C# 12**

---

## 📘 Objetivos do Projeto

Este projeto foi desenvolvido com fins **educacionais** e demonstra:
- Boas práticas de **arquitetura em camadas**;
- Aplicação dos **princípios SOLID**;
- Uso de **injeção de dependência** e **IoC Container**;
- Implementação de **API RESTful documentada com Swagger**;
- Integração com banco de dados via **Entity Framework Core**.

---

## 🧑‍💻 Como Executar o Projeto

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/JsnEvt/EmprestimosLivrosNovo.API.git

2. **Acesse o diretório:**
   ```bash
   cd EmprestimosLivrosNovo.API
3. **Configure o banco de dados:**
   Edite a ConnectionString no arquivo appsettings.json do projeto API.

   Execute as migrations (se aplicável):
  ```bash
  dotnet ef database update
  ```
4. **Execute a aplicação:**
  ```bash
  dotnet run --project EmprestimosLivrosNovo.API
  ```
5. **Acesse o Swagger:**

  https://localhost:{porta}/swagger

☕ Créditos

Projeto baseado na série Café com Bug do YouTube, adaptado e expandido para estudo e aprendizado de arquitetura RESTful em .NET.

🏷️ Licença

Este projeto é de uso livre para fins educacionais.
Sinta-se à vontade para clonar, estudar e evoluir o código!

✨ Desenvolvido com dedicação, café e código limpo ☕💻
