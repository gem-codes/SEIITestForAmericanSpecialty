# SEIITestForAmericanSpecialty Project

This project is a .NET Core Web API application designed to manage employee, manager, and supervisor data. It includes a database-first approach using Entity Framework Core, a repository pattern, and basic CRUD operations.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
  - [Installation](#installation)
  - [Running the Application](#running-the-application)
- [API Endpoints](#api-endpoints)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or any preferred code editor

## Getting Started

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/gem-codes/SEIITestForAmericanSpecialty

1. Open the project in Visual Studio or your preferred code editor.

2. Set up the database connection:

 - Open the appsettings.json file.
 - Update the DefaultConnection under ConnectionStrings with your database connection string.

## Running the Application
Build and run the project:


```bash
dotnet run

```

The API will be accessible at https://localhost:7027/api/person.


## API Endpoints

1. GET /api/person

- Get a list of all people (employees, managers, and supervisors).

2. POST /api/person
- Add a new person (employee, manager, or supervisor).

## Example Request Body:

```bash 
{
  "FirstName": "John",
  "LastName": "Doe",
  "Address1": "123 Main St",
  "PayPerHour": 15.50
}
```

## Project Structure
- DbContextFactory: Contains the AppDbContext class responsible for database interactions.
- Models: Contains the entity classes representing people, employees, managers, and supervisors.
- Repositories: Contains the PersonRepository class handling data access.
- Services: Contains the PersonService class providing business logic.
- Controllers: Contains the PersonController class exposing API endpoints.
