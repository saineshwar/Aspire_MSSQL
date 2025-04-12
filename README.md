# 🗄️ Integrating Microsoft SQL Server (MSSQL) with .NET Aspire

This repository demonstrates how to integrate **Microsoft SQL Server (MSSQL)** with **.NET Aspire**, a powerful and modern framework designed by Microsoft to build scalable, cloud-native applications.

## 🚀 What is .NET Aspire?

[.NET Aspire](https://devblogs.microsoft.com/dotnet/introducing-dotnet-aspire/) simplifies the process of building distributed applications using .NET. It offers built-in tools for:
- Service discovery
- Observability (logs, metrics, tracing)
- Configuration management
- Cloud service integration

## 🧠 Why MSSQL?

**Microsoft SQL Server** is a trusted, enterprise-grade relational database widely used in cloud-native and legacy systems. Integrating it with .NET Aspire allows you to:
- Build robust and scalable data-driven applications
- Use familiar tools like EF Core
- Enable telemetry, health checks, and orchestration

## 📘 Full Tutorial

Follow the full integration guide here:  
🔗 [How to Integrate .NET Aspire with Microsoft SQL Server (MSSQL)](https://tutexchange.com/how-to-integrate-net-aspire-with-microsoft-sql-server-mssql/)

### 📚 What You'll Learn:
- Running MSSQL in Docker using Aspire
- Configuring the database connection using `builder.AddSqlServer(...)`
- Using Entity Framework Core with MSSQL
- Building a minimal API to interact with your database
- Setting up observability with health checks and logs

## 🧰 Tech Stack

- .NET 8 / .NET Aspire
- ASP.NET Core
- Microsoft SQL Server
- Entity Framework Core
- Docker

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Steps to Run

```bash
git clone https://github.com/saineshwar/Aspire_MSSQL.git
cd aspire-mssql-integration
dotnet run --project AspireApp
