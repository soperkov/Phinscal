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

## This will create the necessary database schema and apply migrations.

---

## Step 3: Run the Application

1. Click the **Run (▶️) button in Visual Studio** to start the application.
2. The application will run on **`http://localhost:5000`** or a similar port.

---

## 🎯 Features

### 🔐 User Authentication
- Secure **registration and login**.
- **Password hashing** and validation.
- Persistent user sessions.

### 📦 Order Management
- **Place orders** with multiple options.
- **Schedule delivery** with a date picker.
- **Select payment methods** (Cash, PayPal, Bank Transfer).
- **Real-time order validation**.

### 🎨 UI & UX
- **Modern and responsive** Blazor UI.
- **Modal pop-ups** for terms and conditions.
- **Custom-styled components**.

### ⏳ Countdown Timer
- **Animated countdown clock** for confirmation page.
- **Redirects automatically** after time expires.

---

## 📁 Project Structure

```plaintext
PHINSCAL/
├── Migrations/         # Auto-generated database migrations
├── Components/         # All razor pages
|   ├── Layout/
|   |   ├── MainLayout.razor # Main layout for the app
|   ├── Pages/              # Blazor page components
|   │   ├── Home.razor     # Login page
|   │   ├── Info.razor     # Info page
|   │   ├── OrderDetails.razor  # Order Details page
|   │   ├── Error.razor     # Blazor error page
|   │   ├── Confirmation.razor # Countdown confirmation page
|   ├── _Imports.razor  #Blazor imports page
|   ├── App.razor 
|   ├── Routes.razor
├── Models/             # Data models for the application
│   ├── LoggedInUserModel.cs # Singleton for logged user         
│   ├── UserModel.cs    # User entity
│   ├── OrderModel.cs   # Order entity
│   ├── OrderFormModel.cs # Order form validation
|   ├── RegistrationModel.cs # Registration form validation
├── Services/           # Business logic and services
│   ├── UserService.cs  # Handles user authentication
│   ├── OrderService.cs # Handles order processing

├── wwwroot/            # Static files
│   ├── images/         # Logos and assets
├── appsettings.json    # Database and application settings
├── AppDbContext.cs     # SQL Server tables with columns
├── Program.cs          # Entry point of the application
├── PHINSCAL.csproj     # Project file
└── README.md           # Documentation
```

## 🛠️ Technologies Used

- **Frontend & Backend**: Blazor Web App  
- **Database**: SQL Server  
- **ORM**: Entity Framework Core  
- **Styling**: Custom CSS, Bootstrap, Scoped CSS in Blazor
- **Authentication**: Built-in Blazor authentication & validation
- **Payment Integration**: PayPal, Credit Card, Bank Transfer
