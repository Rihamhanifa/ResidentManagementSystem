# Resident Management System for Grama Niladhari Division

## 📋 Project Overview

The **Resident Management System** is a comprehensive desktop application designed to modernize and streamline the administrative tasks of Grama Niladhari officers in Sri Lanka. This system replaces traditional, inefficient manual record-keeping methods with a secure, automated digital solution. It empowers officers to efficiently manage resident data, ensuring higher accuracy, data security, and improved public service delivery.

This project was developed as part of the **ITE 1943 – ICT Project** for the Bachelor of Information Technology (External Degree) program at the University of Moratuwa.

## ✨ Key Features

*   **🔐 Secure User Authentication:** A robust login system ensures that only authorized personnel can access sensitive resident data.
*   **📊 Centralized Dashboard:** An intuitive, all-in-one dashboard provides a real-time overview of all resident records in a clear, sortable data grid.
*   **➕ Efficient Data Entry:** A structured form with built-in data validation (e.g., NIC format, required fields) minimizes human error during data entry.
*   **🔍 Powerful Search Functionality:** Instantly find any resident record by searching for their Name, NIC number, or Address.
*   **📝 Seamless CRUD Operations:** Easily Create, Read, Update, and Delete resident records through a user-friendly interface.
*   **🛡️ Data Integrity & Security:** Prevents duplicate entries (e.g., duplicate NICs) and ensures critical data is not accidentally deleted through user confirmation dialogs.
*   **💻 Offline Capability:** Built as a standalone desktop application, it functions reliably without requiring a constant internet connection.

## 🛠️ Technology Stack

*   **Language:** C#
*   **Framework:** .NET Framework 4.8 (Windows Forms)
*   **Database:** MySQL (Local instance managed via XAMPP) or SQLite (for portable version)
*   **IDE:** Microsoft Visual Studio 2022

## 🚀 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

*   **Operating System:** Windows 10 or later.
*   **Microsoft Visual Studio 2022** with ".NET desktop development" workload installed.
*   **XAMPP** (if using MySQL version) OR no extra prerequisites if using the SQLite version.

### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/YOUR_USERNAME/ResidentManagementSystem.git
    ```
2.  **Open the project:**
    *   Navigate to the cloned directory and open the `ResidentManagementSystem.sln` file in Visual Studio 2022.
3.  **Database Setup (For MySQL Version):**
    *   Start Apache and MySQL modules in XAMPP Control Panel.
    *   Open phpMyAdmin (`http://localhost/phpmyadmin`).
    *   Create a new database named `resident_database`.
    *   Import the provided `database_script.sql` file (located in the `Database` folder of this repository) to create the necessary tables (`users`, `residents`).
    *   *Note: If using the SQLite version, the database file is already included in the project.*
4.  **Build and Run:**
    *   In Visual Studio, click the "Start" button (or press F5) to build and run the application.
5.  **Login:**
    *   Use the default admin credentials (if set up in your SQL script) to log in.

## 📸 Screenshots

### Login Screen
*(Place a screenshot of your login screen here)*
![Login Screen](path/to/your/login_screenshot.png)

### Main Dashboard
*(Place a screenshot of your dashboard here)*
![Main Dashboard](path/to/your/dashboard_screenshot.png)

### Add/Update Resident Form
*(Place a screenshot of your add/update form here)*
![Ad
