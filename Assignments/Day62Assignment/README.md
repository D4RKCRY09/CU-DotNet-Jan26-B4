<div align="center">
  <h1>🏦 Loan Management Web API</h1>
  <p><b>RESTful Service Development with ASP.NET Core & EF Core</b></p>
</div>

<hr />

## 📌 Overview

This repository features a robust **Loan Management System** built on the ASP.NET Core 8.0/10.0 framework. The application demonstrates the transition from a C# "Noun" (Entity) to a persistent database record using **Entity Framework Core**, providing a full suite of CRUD (Create, Read, Update, Delete) operations for financial records.

---

## 🚀 Architectural Components

### 🔹 1. The Data Model (The Entity)

The system centers around the `Loan` entity, which serves as the blueprint for the database schema:

* `<b>`Identity:`</b>` Managed via a unique `Id` (Primary Key).
* `<b>`Financial Data:`</b>` Tracks `BorrowerName`, `Amount` (using `decimal` for precision), and `LoanTermMonths`.
* `<b>`Status:`</b>` A boolean `IsApproved` flag to manage the loan lifecycle.

### 🔹 2. The Persistence Layer (EF Core)

Utilizing Object-Relational Mapping (ORM) to bridge the gap between C# code and SQL storage:

* `<b>`DbContext:`</b>` The `LoanDbContext` acts as the primary session with the database.
* `<b>`Dependency Injection:`</b>` The context is registered in `Program.cs`, allowing controllers to access data services efficiently.
* `<b>`Migrations:`</b>` Uses `dotnet ef` tools to translate C# classes into physical database tables.

### 🔹 3. API Controller Logic

The `LoansController` is decorated with `[ApiController]` and `[Route("api/[controller]")]` to handle standard HTTP verbs:

* `<b>`POST:`</b>` Captures new applications and returns a `201 Created` status.
* `<b>`GET:`</b>` Retrieves individual or collective loan records with a `200 OK`.
* `<b>`PUT/DELETE:`</b>` Manages record updates (approvals) and removals, returning `204 No Content` upon success.

---

## 🧪 Postman Validation Workflow

To ensure the API meets production standards, the following four-step testing suite is implemented:

| Step                | HTTP Method | Expected Status    | Description                                                      |
| :------------------ | :---------- | :----------------- | :--------------------------------------------------------------- |
| **1. Create** | `POST`    | `201 Created`    | Submits JSON body and returns the object with an assigned ID.    |
| **2. Read**   | `GET`     | `200 OK`         | Retrieves the array of loans from the database.                  |
| **3. Update** | `PUT`     | `204 No Content` | Approves a loan by toggling `isApproved` to true.              |
| **4. Delete** | `DELETE`  | `204 No Content` | Removes the record; confirmed by a subsequent `404 Not Found`. |

---

## 📋 Technical Requirements Checklist

<ul>
  <li><b>Framework:</b> ASP.NET Core 8.0+</li>
  <li><b>Database:</b> SQL Server / SQLite</li>
  <li><b>Tooling:</b> Postman for endpoint validation.</li>
  <li><b>Patterns:</b> Repository Pattern (via EF Core) and Dependency Injection.</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed to demonstrate mastery over modern RESTful architecture and enterprise data persistence.</i></p>
</div>

![1773989150656](image/README/1773989150656.png)

![1773989164088](image/README/1773989164088.png)

![1773989171065](image/README/1773989171065.png)


![1773989181800](image/README/1773989181800.png)
