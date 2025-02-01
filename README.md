# PHINSCAL

Welcome to the **PHINSCAL** repository! This project is a **Blazor Web App** built with **Entity Framework Core** and **SQL Server** as the database. PHINSCAL provides user authentication, order management, and other essential functionalities.

---

## 📌 Table of Contents

- [Getting Started](#getting-started)
- [Features](#features)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)

---

## 🚀 Getting Started

Follow these steps to set up and run the application on your local machine.

### **Step 1: Configure the Database Connection**

1. Open the `appsettings.json` file located in the root of the project.
2. Update the **server name** in the `ConnectionStrings` section to match your local SQL Server configuration:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=PhinscalDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }

### **Step 2: Set Up the Database**

1. Open **Visual Studio** and **select the PHINSCAL project**.
2. Open the **Package Manager Console (PMC)**:
   - Navigate to **Tools** → **NuGet Package Manager** → **Package Manager Console**.
3. Run the following commands:

   ```powershell
   Add-Migration InitialMigration
   Update-Database

- This will create the necessary database schema and apply migrations.

---

### **Step 4: Configure Application Settings**

1. Open the **`appsettings.json`** file in the root of the project.
2. Ensure that the database connection string is correctly set:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=PhinscalDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
