# 📚 Capstone Project – Library Management Web API

## 📖 Overview
This project is a **.NET 7 Web API** that manages **Books**, **Users**, and **Loans** for a library system.  
It demonstrates **core object-oriented programming principles**:
- **Encapsulation** – Private fields with controlled public access
- **Inheritance** – Shared base classes like `MediaItem` and `Person`
- **Abstraction** – Interfaces like `ILoanable` for common behaviors

The API is organized into separate controllers for **Books**, **Users**, and **Loans**, following RESTful conventions.

---

## 🛠 Tech Stack
- **C#** / **.NET 7**
- **ASP.NET Core Web API**
- **MSTest** for unit testing
- **Swagger / OpenAPI** for API documentation
- **In-Memory Data Storage** (demo purposes)

---

## ✨ Features
### 📘 Books
- `GET /books` – List all books
- `GET /books/{id}` – View one book
- `POST /books` – Add a new book
- `PUT /books/{id}` – Update an existing book
- `DELETE /books/{id}` – Remove a book

### 👤 Users
- `GET /users` – List all users
- `POST /users` – Add a new user

### 🔁 Loans
- `GET /loans` – List all current loans
- `POST /loans` – Check out a book
- `POST /returns` – Return a book

---


