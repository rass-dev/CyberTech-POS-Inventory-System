<p align="center">
  <img src="Screenshots/logo.png" width="120"/>
</p>

<h2 align="center">CyberTech POS & Inventory System</h2>

---

## Info
CyberTech is a computer parts retail system built using C# and .NET. It combines point-of-sale (POS) functionality with inventory management, enabling efficient sales processing, stock monitoring, and business operations through a centralized desktop application.

---

## Features
- Point-of-Sale (POS) with cart and checkout  
- Inventory management system  
- Dashboard analytics and reporting  
- Sales tracking and transaction history  
- Product, category, and supplier management  
- Secure login and user authentication  

---

## Tech Stack
- Language: C#  
- Framework: .NET (Windows Forms / WPF)  
- Database: Microsoft SQL Server / LocalDB  
- IDE: Microsoft Visual Studio  

---

## Screenshots

### Login
![Login](Screenshots/login.png)

### Dashboard
![Dashboard](Screenshots/dashboard.png)

### POS
![POS](Screenshots/pos.png)

### Inventory
![Inventory](Screenshots/inventory.png)

---

## Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/rass-dev/CyberTech-POS-Inventory-System.git
cd CyberTech-POS-Inventory-System
```

### 2. Open in Visual Studio
- Open Microsoft Visual Studio  
- Click "Open a project or solution"  
- Select the `.sln` file  

---

### 3. Restore Database (Using .bak File)

A pre-configured database backup is included:

```
database/db_computer_parts_pos_management.bak
```

#### Steps:
1. Open SQL Server Management Studio (SSMS)  
2. Connect to your SQL Server instance  
3. Right-click **Databases** → Click **Restore Database**  
4. Select **Device** → Click **...** → Add the `.bak` file  
5. Choose `db_computer_parts_pos_management.bak`  
6. Set database name (e.g. `CyberTechDB`)  
7. Click **OK** to restore  

---

### 4. Configure Connection String

Open `App.config` and update:

```xml
<connectionStrings>
  <add name="DefaultConnection"
       connectionString="Server=.;Database=CyberTechDB;Trusted_Connection=True;" />
</connectionStrings>
```

---

### 5. Run the Application
- Build the solution  
- Press **F5** or click **Start** to run  

---

## Usage

### Admin / Staff
- Process sales using POS interface  
- Manage inventory and stock levels  
- Add/edit products, categories, and suppliers  
- View sales reports and transaction history  

---

## Notes
- Requires Microsoft Visual Studio to run  
- Ensure SQL Server or LocalDB is properly configured  
- A ready-to-use SQL Server backup file (`.bak`) is included in the `/database` folder  
- Update connection string if using a different SQL Server instance  
