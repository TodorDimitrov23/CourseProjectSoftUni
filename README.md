# CourseProjectSoftUni
📚 BookVue
📖 Project Overview

BookVue is a full-stack book shop and review platform developed as an individual software engineering project.

The system is designed for a physical book shop that wants to expand its reach through a digital platform. It allows:

Readers to discover and purchase books

Authors to publish and manage their books

Book Managers (administrators) to maintain and moderate the system

The solution consists of:

🌐 ASP.NET Web Application (for Readers & Authors)

🖥 Windows Desktop Application (for Book Managers)

🗄 MS SQL Database

🎯 Project Goal

The goal of BookVue is to:

Provide easier access to books for regular customers

Allow Authors to publish their books digitally

Help the book shop reach a wider audience

Increase business revenue and customer engagement

👥 User Roles
1️⃣ Readers

Register and login

Search and browse books

Buy books

Add books to personal list

Rate and review books

2️⃣ Authors

Register and login

Publish new books

Delete their published books

Buy and review other books

3️⃣ Book Managers (Admin - Desktop App)

Manage users (ban / update roles)

Approve or delete books

Moderate content

Manage shop inventory

🚀 Main Features
Web Application (ASP.NET)

User registration and authentication

Role-based access (Reader / Author)

Book search and filtering

Book publishing system

Shopping functionality

Rating & review system

Desktop Application (Windows)

Book management

User moderation

Content control

Administrative functionality

🛠 Technologies Used

C#

ASP.NET (MVC / Core)

.NET

Windows Forms / WPF (Desktop App)

MS SQL Server

Entity Framework

Visual Studio 2022

Git & GitHub

🏗 System Architecture

The system follows a layered architecture:

Presentation Layer (Web & Desktop UI)

Business Logic Layer

Data Access Layer (DAL)

Database Layer (MS SQL)

🗄 Database

The application uses Microsoft SQL Server.

The database manages:

Users

Roles

Books

Reviews

Purchases

⚙️ Setup Instructions
1️⃣ Clone the Repository
git clone https://github.com/TodorDimitrov23/CourseProjectSoftUni.git

2️⃣ Open the Solution

Open:

BookVueWebApplication.sln


in Visual Studio 2022

3️⃣ Configure Database

Open appsettings.json

Update the connection string to your local SQL Server:

Example:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=BookVueDB;Trusted_Connection=True;"
}

4️⃣ Apply Migrations (If using EF Core)

In Package Manager Console:

Update-Database

5️⃣ Run the Application

Set Web project as Startup Project

Press F5

For Desktop App:

Set Desktop project as Startup Project

Run separately

🧪 Testing Strategy

The project includes:

Unit testing

Integration testing

User Acceptance Testing (UAT)

📌 Project Scope

Included:

Book management

User roles

Purchasing system

Reviews

Not included:

Advanced statistics

Maintenance & training

Future scalability features

📅 Development Methodology

The project was developed using:

Agile approach

Phase-based implementation:

Planning

Design

Development

Testing

Deployment

👨‍💻 Author

Todor Dimitrov
