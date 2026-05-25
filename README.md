# Project & Task Management API

A scalable backend API built with ASP.NET Core Web API using Clean Architecture principles.

## Tech Stack

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

## 1. Domain
Contains:
- Entities
- Enums
- Interfaces
- Business rules

## 2. Application
Contains:
- CQRS Commands & Queries
- Validators
- Interfaces
- MediatR Handlers

## 3. Infrastructure
Contains:
- EF Core DbContext
- Database configuration

## 4. Presentation/API
Contains:
- Controllers
- Middleware
- Dependency Injection
- JWT Configuration
- Global Exception Handling

---

# Features

## Authentication
- Register
- Login with JWT

## Projects
- Create Project
- Get All Projects
- Get Project By Id
- Update Project
- Delete Project

## Tasks
- Create Task
- Update Task Status
- Get Tasks By Project
- Delete Task

---

# Setup Instructions

## 1. Clone Repository

```bash
git clone <repo-url>
cd ProjectName# Project & Task Management API

A scalable backend API built with ASP.NET Core Web API using Clean Architecture principles.

## Tech Stack

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

## 1. Domain
Contains:
- Entities
- Enums
- Interfaces
- Business rules

## 2. Application
Contains:
- CQRS Commands & Queries
- DTOs
- Validators
- Interfaces
- MediatR Handlers

## 3. Infrastructure
Contains:
- EF Core DbContext
- Repository implementations
- Authentication services
- Database configuration

## 4. Presentation/API
Contains:
- Controllers
- Middleware
- Dependency Injection
- JWT Configuration
- Global Exception Handling

---

# Features

## Authentication
- Register
- Login with JWT

## Projects
- Create Project
- Get All Projects
- Get Project By Id
- Update Project
- Delete Project

## Tasks
- Create Task
- Update Task Status
- Get Tasks By Project
- Delete Task

---

# Setup Instructions

## 1. Clone Repository

```bash
git clone <repo-url>
cd ProjectName