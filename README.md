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
### 2. Build the Project

```
dotnet build
```

### 3. Run the Project
```
dotnet run
```

The application will run at https://localhost:5001 by default.

### 4. Access Swagger UI
Navigate to https://localhost:5001/swagger to test the API endpoints and perform CRUD operations for users and tasks.

### Project Structure

- Controllers: Contains API endpoints (TaskController, UserController).
- Data: Includes ApplicationDbContext for database operations.
- Models: Contains User and Task models.
- Tests: xUnit tests for key functionalities.

### Seeding the Database

The database will be seeded with initial user data via the DatabaseSeeder.cs file during startup. If you want to modify or reset the seed data:

1. Update the DatabaseSeeder.cs file with the desired data.
2. Delete the database.db file.
3. Run the project to regenerate the database with the new seed data.

### Running Tests
Tests are located in the DataBalkCSharp.Tests project. Run tests with:
```
dotnet test
```
