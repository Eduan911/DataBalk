DataBalkC#
A simple API application built using ASP.NET Core, featuring user authentication with JWT tokens and task management functionality.

Features
User Management:

Create, read, update, and delete (CRUD) users via Swagger documentation.
User authentication using JWT tokens.
Task Management:

CRUD operations for tasks via Swagger documentation.
Fetch tasks by status (e.g., expired, active, etc.).
Authentication:

Login endpoint issues JWT tokens for secure access.
Database:

SQLite database with seed data for initial setup.
Unit Tests:

Written with xUnit and Moq to validate core functionalities.
Swagger Documentation:

Provides an interactive interface to test the API.
Prerequisites
Ensure you have the following installed:

.NET 6.0 or later
SQLite (optional, as the project uses a local database file)
Getting Started
1. Clone the Repository
bash
Copy code
git clone https://github.com/<your-username>/DataBalkCSharp.git
cd DataBalkCSharp
2. Build the Project
bash
Copy code
dotnet build
3. Run the Project
bash
Copy code
dotnet run
The application will run at https://localhost:5001 by default.

4. Access Swagger UI
Navigate to https://localhost:5001/swagger to test the API endpoints and perform CRUD operations for users and tasks.

Project Structure
Controllers: Contains API endpoints (TaskController, UserController).
Data: Includes ApplicationDbContext for database operations.
Models: Contains User and Task models.
Tests: xUnit tests for key functionalities.
Configuration
appsettings.json
Ensure the appsettings.json file contains appropriate configuration for the JWT and database. Example:

json
Copy code
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Jwt": {
    "Key": "super_secure_generated_key_12345",
    "Issuer": "yourissuer",
    "Audience": "youraudience"
  }
}
Seeding the Database
The database will be seeded with initial user data via the DatabaseSeeder.cs file during startup. If you want to modify or reset the seed data:

Update the DatabaseSeeder.cs file with the desired data.
Delete the database.db file.
Run the project to regenerate the database with the new seed data.
Running Tests
Tests are located in the DataBalkCSharp.Tests project. Run tests with:

bash
Copy code
dotnet test
Deployment
GitHub Repository Setup
Initialize a local Git repository (if not already):

bash
Copy code
git init
Add your files:

bash
Copy code
git add .
git commit -m "Initial commit"
Create a GitHub repository:

Go to GitHub and create a new repository.

Add the GitHub remote:

bash
Copy code
git remote add origin https://github.com/<your-username>/DataBalkCSharp.git
Push your code:

bash
Copy code
git branch -M main
git push -u origin main
Notes
Add *.db, *.db-shm, and *.db-wal to your .gitignore file to prevent local database files from being pushed to GitHub.
Use the seed data to create test users and tasks for initial testing.
License
MIT License
