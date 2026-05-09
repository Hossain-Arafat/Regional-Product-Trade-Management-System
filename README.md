# Regional Product Trade Management System

<p align="center">
  A role-based desktop marketplace platform for managing regional product trading, order processing, seller ratings, and district-based commerce.
</p>

<p align="center">
  
  ![Platform](https://img.shields.io/badge/Platform-Windows-blue)
  ![Framework](https://img.shields.io/badge/.NET_Framework-4.7.2-purple)
  ![Language](https://img.shields.io/badge/Language-C%23-239120)
  ![Database](https://img.shields.io/badge/Database-SQL_Server-red)
  ![Architecture](https://img.shields.io/badge/Architecture-Layered-orange)

</p>

---

## Project Overview

The **Regional Product Trade Management System** is a Windows Forms-based desktop application designed to digitize and streamline regional commerce between buyers and sellers.

The platform enables:
- Sellers to list and manage regional products
- Buyers to browse products, place orders, and rate sellers
- Administrators to oversee users, orders, products, and requests

The application follows a **role-based architecture** with dedicated workflows for **Admin**, **Seller**, and **Buyer** accounts. It combines inventory management, transaction handling, payment tracking, and district-based filtering into a centralized marketplace system.

This project was built using **C# (.NET Framework)** and **Microsoft SQL Server**, with direct database interaction implemented through **ADO.NET and parameterized SQL queries**.

---

## ✨ Core Features

### 👨‍💼 Admin Panel
- Monitor platform-wide activity
- View all users, products, and orders
- Manage buyer product requests
- Track marketplace operations through centralized dashboards

### 🛍️ Seller Module
- Add and manage product listings
- Upload product images and descriptions
- Track incoming orders
- Monitor seller ratings and feedback
- Manage inventory availability

### 🧑‍💻 Buyer Module
- Browse products by district/region
- View detailed product and seller information
- Place and manage orders
- Submit product requests for unavailable items
- Rate sellers after purchase completion

### 🔐 Authentication & Access Control
- Role-based login system
- Session-based navigation
- Profile management and password update functionality

---

## 🧠 Engineering Highlights

- Implemented a **layered desktop application architecture** separating UI, business logic, and database operations
- Used **parameterized SQL queries** to reduce SQL injection risks
- Applied **transaction-based order processing** to maintain inventory consistency during purchases
- Designed a **district-aware marketplace system** for regional product discovery
- Structured the system into modular forms for scalability and maintainability

---

## 🏗️ System Architecture

```text
┌─────────────────────────────────────────┐
│         Presentation Layer              │
│        Windows Forms UI Components      │
└──────────────────┬──────────────────────┘
                   │
┌──────────────────▼──────────────────────┐
│         Business Logic Layer            │
│      Authentication, Orders, Payment    │
└──────────────────┬──────────────────────┘
                   │
┌──────────────────▼──────────────────────┐
│          Data Access Layer              │
│      ADO.NET + SqlClient Operations     │
└──────────────────┬──────────────────────┘
                   │
┌──────────────────▼──────────────────────┐
│            SQL Server Database          │
│ Users, Products, Orders, Payments       │
└─────────────────────────────────────────┘
```

---

## 🛠️ Tech Stack

| Category | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI Framework | Windows Forms |
| Database | Microsoft SQL Server |
| Data Access | ADO.NET (`SqlClient`) |
| IDE | Visual Studio 2017+ |
| Architecture | Layered Architecture |
| Database Backup | `.bacpac` |

---

## 📂 Project Structure

```text
Regional-Product-Trade-Management-System/
├── regionalProductTrade/                 # Main project folder
│   ├── Program.cs                        # Application entry point
│   ├── App.config                        # Application configuration
│   ├── DatabaseConnection.cs             # Database connection helper
│   │
│   ├── Authentication & Core
│   │   ├── Login.cs                      # User login form
│   │   ├── createaccount.cs              # User registration form
│   │   ├── ChangePass.cs                 # Password management
│   │   └── UpdateProfile.cs              # User profile update
│   │
│   ├── Admin Module
│   │   ├── AdminDashboard.cs             # Admin main dashboard
│   │   ├── AdminViewOrder.cs             # View all orders
│   │   ├── AdminViewProduct.cs           # View all products
│   │   └── AdminViewRequest.cs           # View product requests
│   │
│   ├── Buyer Module
│   │   ├── buyerDashboard.cs             # Buyer main dashboard
│   │   ├── BuyerViewProduct.cs           # Browse products
│   │   ├── BuyerOrder.cs                 # View buyer orders
│   │   ├── ProductDetails.cs             # Product details & order placement
│   │   ├── Payment.cs                    # Payment processing
│   │   ├── RateSeller.cs                 # Rate seller experience
│   │   ├── ViewRating.cs                 # View seller ratings
│   │   └── RequestProduct.cs             # Request specific products
│   │
│   ├── Seller Module
│   │   ├── SellerDashboard.cs            # Seller main dashboard
│   │   ├── SellerAddProduct.cs           # Add new products
│   │   ├── SellerOrder.cs                # View received orders
│   │   ├── SellerProductDetails.cs       # Manage product details
│   │   ├── SellerViewProductsFrom.cs     # Browse regional products
│   │   └── SellerProductDetails.cs       # Edit product information
│   │
│   ├── Utilities
│   │   └── DatabaseForm.cs               # Database configuration form
│   │
│   ├── Resources/
│   │   └── Product_Image/                # Product image storage directory
│   │   └── *.png, *.jpg                  # UI resource files
│   │
│   ├── Properties/
│   │   ├── AssemblyInfo.cs               # Assembly metadata
│   │   ├── Resources.Designer.cs         # Resource definitions
│   │   └── Settings.Designer.cs          # Application settings
│   │
│   ├── *.Designer.cs files               # Auto-generated UI component definitions
│   ├── *.resx files                      # Resource files for each form
│   │
│   └── regionalProductTrade.csproj       # Project file with dependencies
│
├── regionalProductTrade.sln              # Visual Studio solution file
├── regionalProductTrade.bacpac           # SQL Server database backup
├── favicon.ico                           # Application icon
└── README.md                             # This file
```

---

## 🗄️ Database Design

### Main Entities

| Table | Purpose |
|---|---|
| `Users` | Stores Admin, Buyer, and Seller accounts |
| `Product` | Product listings and inventory |
| `Orders` | Order tracking and transaction records |
| `Payment` | Payment history and methods |
| `District` | Regional district information |
| `Rating` | Buyer feedback for sellers |
| `ProductRequest` | Buyer requests for unavailable products |

### Example Relationship Flow

```text
Buyer → Orders → Product → Seller
                  ↓
               Payment
                  ↓
                Rating
```

---

## 🔄 Order Processing Workflow

```text
Browse Product
      ↓
Place Order
      ↓
Process Payment
      ↓
Seller Confirmation
      ↓
Order Delivery
      ↓
Buyer Rating & Feedback
```

The system uses transactional database operations to ensure product quantity remains synchronized during concurrent order placement.

---

## 🚀 Installation & Setup

### Prerequisites

- Windows OS
- .NET Framework 4.7.2
- Microsoft SQL Server
- Visual Studio 2017 or later

---

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/Hossain-Arafat/Regional-Product-Trade-Management-System.git
cd Regional-Product-Trade-Management-System
```

---

### 2️⃣ Restore the Database

Import the included `.bacpac` file into SQL Server using SQL Server Management Studio (SSMS).

Database file:
```text
regionalProductTrade.bacpac
```

---

### 3️⃣ Configure Database Connection

Update the connection string inside:

```text
regionalProductTrade/DatabaseConnection.cs
```

Example:

```csharp
public static readonly string ConnectionString =
    "data source=YOUR_SERVER; initial catalog=regionalProductTrade; user id=YOUR_USER; password=YOUR_PASSWORD;";
```

---

### 4️⃣ Build & Run

Open the solution file in Visual Studio:

```text
regionalProductTrade.sln
```

Then:
- Build the project (`Ctrl + Shift + B`)
- Run the application (`F5`)

---

## 🔒 Security & Technical Notes

### Implemented
- Parameterized SQL queries
- Session-based authentication
- Role-based authorization
- Transaction-based order handling

### Current Limitations
- Database connection string is stored in code
- Password hashing is not yet implemented
- No automated testing framework currently included

These are acknowledged technical limitations and identified areas for future improvement.

---

## 🔮 Future Improvements

- Password hashing and stronger authentication
- Real payment gateway integration
- Advanced search and filtering
- Product categories and recommendations
- Pagination and performance optimization
- Migration to ASP.NET Core or modern web architecture
- Reporting and analytics dashboard
- Unit and integration testing

---

## 🤝 Contribution

Contributions, improvements, and issue reports are welcome.

### Steps
```bash
# Fork repository
# Create feature branch
git checkout -b feature/feature-name

# Commit changes
git commit -m "Add: feature description"

# Push branch
git push origin feature/feature-name
```

Then create a Pull Request.

---

## 📄 License

This project is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more information.

---

## 👤 Author

### Arafat Hossain

- GitHub: [Hossain-Arafat](https://github.com/Hossain-Arafat)
- Repository: [Regional Product Trade Management System](https://github.com/Hossain-Arafat/Regional-Product-Trade-Management-System)

