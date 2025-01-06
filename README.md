# DataBalkC#

A simple API application built using ASP.NET Core, featuring user authentication with JWT tokens and task management functionality.

## Features

1. **User Management**:
   - Create, read, update, and delete (CRUD) users via Swagger documentation.
   - User authentication using JWT tokens.

2. **Task Management**:
   - CRUD operations for tasks via Swagger documentation.
   - Fetch tasks by status (e.g., expired, active, etc.).

3. **Authentication**:
   - Login endpoint issues JWT tokens for secure access.

4. **Database**:
   - SQLite database with seed data for initial setup.

5. **Unit Tests**:
   - Written with xUnit and Moq to validate core functionalities.

6. **Swagger Documentation**:
   - Provides an interactive interface to test the API.

## Prerequisites

Ensure you have the following installed:

- [.NET 6.0 or later](https://dotnet.microsoft.com/download)
- SQLite (optional, as the project uses a local database file)

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/<your-username>/DataBalkCSharp.git
cd DataBalkCSharp
```
