# TaskFlow API

A scalable backend API built with ASP.NET Core Web API using Clean Architecture principles.

---

# Tech Stack

- ASP.NET Core Web API (.NET 9)
- Entity Framework Core
- SQL Server
- JWT Authentication
- Clean Architecture
- MediatR
- FluentValidation

---

# Architecture Overview

The project follows Clean Architecture and is divided into the following layers:

## 1. Domain Layer
Contains:
- Entities
- Enums
- Interfaces
- Business Rules

## 2. Application Layer
Contains:
- CQRS Commands & Queries
- DTOs
- Validators
- MediatR Handlers
- Abstractions

## 3. Infrastructure Layer
Contains:
- Entity Framework Core
- Database Context
- Repository Implementations
- JWT Token Generation
- Dependency Injection

## 4. Presentation/API Layer
Contains:
- Controllers
- Middleware
- Swagger Configuration
- Authentication Configuration
- Global Exception Handling

---

# Features

## Authentication
- JWT Token Generation
- Secured Endpoints using Authorization

## Projects Module
- Create Project
- Get All Projects
- Get Project By Id
- Update Project
- Delete Project

## Tasks Module
- Create Task
- Update Task Status
- Get Tasks By Project
- Delete Task

---

# Project Structure

```bash
src/
 ├── TaskFlow.Api
 ├── TaskFlow.Application
 ├── TaskFlow.Domain
 └── TaskFlow.Infrastructure
```

---

# Setup Instructions

## 1. Clone Repository

```bash
git clone https://github.com/AbdelrahmanAhmedKamar/TaskFlow.git
```

---

## 2. Configure Database

Update the connection string inside:

```bash
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=TaskFlowDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

## 3. Apply Database Migrations

```bash
dotnet ef database update --project .\src\TaskFlow.Infrastructure --startup-project .\src\TaskFlow.Api
```

---

## 4. Create New Migration

```bash
dotnet ef migrations add Initial --project .\src\TaskFlow.Infrastructure --startup-project .\src\TaskFlow.Api --output-dir Data\Migrations
```

---

## 5. Run The Project

```bash
dotnet run --project .\src\TaskFlow.Api
```

---

# Swagger Documentation

Swagger is enabled by default.

Example:

```bash
https://localhost:7003/swagger
```

---

# Database Migrations

Migration files are included inside:

```bash
src/TaskFlow.Infrastructure/Data/Migrations
```

---

# Design Principles

- Clean Architecture
- SOLID Principles
- Dependency Injection
- Separation of Concerns
- Scalable Structure
- Maintainable Code

---

# Additional Implementations

- Global Exception Handling
- FluentValidation
- Generic Result Pattern
- CQRS Pattern using MediatR

---

# Author

Abdelrahman Ahmed