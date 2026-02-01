# Home Library Management System (Razor Pages)

A web-based **Home Library Management System** built using **ASP.NET Core Razor Pages**.  
The application allows users to manage a personal book collection through a clean and simple web interface.  
It uses **SQLite** as a lightweight database, **Entity Framework Core** for data access, and **LINQ** for querying and manipulating data.  
The project was built on .NET 8.0 and later updated to **.NET 10.0**.

---

## Features

- Add, edit, and delete books in the home library  
- Customize the library layout by adding or removing rooms, bookshelves, and shelves  
- Persistent data storage with SQLite  
- Web-based UI built with Razor Pages  
- Server-side rendering with ASP.NET Core  

---

## Technologies Used

- **ASP.NET Core Razor Pages** – Web application framework  
- **C# (.NET 10.0)** – Core application logic  
- **Entity Framework Core** – ORM for database access  
- **LINQ** – Data querying and filtering  
- **SQLite** – Lightweight embedded database  

---

## Concepts Implemented

- Razor Pages architecture  
- CRUD operations with Entity Framework Core
- LINQ queries for filtering and searching data  
- Model binding and validation  

---

## ⚙️ Getting Started

### Prerequisites

- .NET SDK 10.0  

---

### Installation & Run

1. Clone the repository:
  ```bash
  git clone https://github.com/tylko00/homelibrary-razorpages.git
  ```
2. Navigate to the project directory:
  ```bash
  cd homelibrary-razorpages
  ```
3. Restore dependencies:
  ```bash
  dotnet restore
  ```
4. Run the application:
  ```bash
  dotnet run
  ```
5. Open your browser and navigate to the URL shown in the command line output
(for example: http://localhost:5000)
