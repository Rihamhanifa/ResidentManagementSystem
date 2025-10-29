# Resident Management System for Grama Niladhari Division

![Project Status](https://img.shields.io/badge/status-complete-green)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Language](https://img.shields.io/badge/language-C%23-purple)

## 📖 About The Project

The **Resident Management System** is a standalone desktop application designed to digitize and streamline the administrative tasks of Grama Niladhari divisions in Sri Lanka. It replaces traditional, inefficient paper-based record-keeping with a secure, automated digital solution.

This system allows authorized officers to efficiently manage resident data, ensuring accuracy, security, and quick retrieval of information. It was developed as part of the ITE 1943 ICT Project (Level 01) for the Bachelor of Information Technology degree at the University of Moratuwa.

### Key Features
*   **Secure User Authentication:** Role-based login to prevent unauthorized access.
*   **Centralized Dashboard:** An intuitive interface for managing all resident records.
*   **CRUD Operations:** Easily Add, View, Update, and Delete resident records.
*   **Powerful Search:** Instantly filter records by Full Name, NIC number, or Address.
*   **Data Validation:** Robust input checks to ensure data integrity (e.g., NIC format, required fields).
*   **User-Friendly Interface:** Designed for ease of use with logical tab ordering and helpful tooltips.

## 🛠️ Built With

*   [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Primary programming language.
*   [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) - Windows Forms (WinForms) for the user interface.
*   [MySQL](https://www.mysql.com/) - Relational database for data storage (managed via XAMPP).
*   [Visual Studio 2022](https://visualstudio.microsoft.com/) - Integrated Development Environment (IDE).

## 🚀 Getting Started

To run this project locally, follow these steps.

### Prerequisites
*   Windows Operating System (Windows 10/11 recommended).
*   [XAMPP](https://www.apachefriends.org/download.html) installed and running (Apache & MySQL modules).
*   .NET Framework 4.8 or later.

### Installation & Setup

1.  **Clone the Repository**
    ```sh
    git clone https://github.com/# Resident Management System for Grama Niladhari Division

![Project Status](https://img.shields.io/badge/status-complete-green)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Language](https://img.shields.io/badge/language-C%23-purple)

## 📖 About The Project

The **Resident Management System** is a standalone desktop application designed to digitize and streamline the administrative tasks of Grama Niladhari divisions in Sri Lanka. It replaces traditional, inefficient paper-based record-keeping with a secure, automated digital solution.

This system allows authorized officers to efficiently manage resident data, ensuring accuracy, security, and quick retrieval of information. It was developed as part of the ITE 1943 ICT Project (Level 01) for the Bachelor of Information Technology degree at the University of Moratuwa.

### Key Features
*   **Secure User Authentication:** Role-based login to prevent unauthorized access.
*   **Centralized Dashboard:** An intuitive interface for managing all resident records.
*   **CRUD Operations:** Easily Add, View, Update, and Delete resident records.
*   **Powerful Search:** Instantly filter records by Full Name, NIC number, or Address.
*   **Data Validation:** Robust input checks to ensure data integrity (e.g., NIC format, required fields).
*   **User-Friendly Interface:** Designed for ease of use with logical tab ordering and helpful tooltips.

## 🛠️ Built With

*   [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Primary programming language.
*   [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) - Windows Forms (WinForms) for the user interface.
*   [MySQL](https://www.mysql.com/) - Relational database for data storage (managed via XAMPP).
*   [Visual Studio 2022](https://visualstudio.microsoft.com/) - Integrated Development Environment (IDE).

## 🚀 Getting Started

To run this project locally, follow these steps.

### Prerequisites
*   Windows Operating System (Windows 10/11 recommended).
*   [XAMPP](https://www.apachefriends.org/download.html) installed and running (Apache & MySQL modules).
*   .NET Framework 4.8 or later.

### Installation & Setup

1.  **Clone the Repository**
    ```sh
    git clone https://github.com/# Resident Management System for Grama Niladhari Division

![Project Status](https://img.shields.io/badge/status-complete-green)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Language](https://img.shields.io/badge/language-C%23-purple)

## 📖 About The Project

The **Resident Management System** is a standalone desktop application designed to digitize and streamline the administrative tasks of Grama Niladhari divisions in Sri Lanka. It replaces traditional, inefficient paper-based record-keeping with a secure, automated digital solution.

This system allows authorized officers to efficiently manage resident data, ensuring accuracy, security, and quick retrieval of information. It was developed as part of the ITE 1943 ICT Project (Level 01) for the Bachelor of Information Technology degree at the University of Moratuwa.

### Key Features
*   **Secure User Authentication:** Role-based login to prevent unauthorized access.
*   **Centralized Dashboard:** An intuitive interface for managing all resident records.
*   **CRUD Operations:** Easily Add, View, Update, and Delete resident records.
*   **Powerful Search:** Instantly filter records by Full Name, NIC number, or Address.
*   **Data Validation:** Robust input checks to ensure data integrity (e.g., NIC format, required fields).
*   **User-Friendly Interface:** Designed for ease of use with logical tab ordering and helpful tooltips.

## 🛠️ Built With

*   [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Primary programming language.
*   [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) - Windows Forms (WinForms) for the user interface.
*   [MySQL](https://www.mysql.com/) - Relational database for data storage (managed via XAMPP).
*   [Visual Studio 2022](https://visualstudio.microsoft.com/) - Integrated Development Environment (IDE).

## 🚀 Getting Started

To run this project locally, follow these steps.

### Prerequisites
*   Windows Operating System (Windows 10/11 recommended).
*   [XAMPP](https://www.apachefriends.org/download.html) installed and running (Apache & MySQL modules).
*   .NET Framework 4.8 or later.

### Installation & Setup

1.  **Clone the Repository**
    ```sh
    git clone https://github.com/Rihamhanifa/resident-management-system.git
    ```
2.  **Database Setup**
    *   Open **XAMPP Control Panel** and start **Apache** and **MySQL**.
    *   Go to `http://localhost/phpmyadmin` in your browser.
    *   Create a new database named `resident_database`.
    *   Select the new database, go to the **SQL** tab, and execute the following script to create the necessary tables and a default admin user:

    ```sql
    CREATE TABLE users (
        Username VARCHAR(50) NOT NULL PRIMARY KEY,
        Password VARCHAR(50) NOT NULL
    );

    INSERT INTO users (Username, Password) VALUES ('admin', '123');

    CREATE TABLE residents (
        id INT AUTO_INCREMENT PRIMARY KEY,
        full_name VARCHAR(100) NOT NULL,
        dob DATE NOT NULL,
        nic VARCHAR(12) UNIQUE NOT NULL,
        address TEXT NOT NULL,
        phone VARCHAR(15),
        email VARCHAR(100),
        occupation VARCHAR(50),
        gender ENUM('Male', 'Female', 'Other') NOT NULL,
        registered_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
    );
    ```

3.  **Run the Application**
    *   Navigate to the project folder and open the solution file (`.sln`) in Visual Studio.
    *   Build and run the project (F5).
    *   **Login Credentials:**
        *   Username: `admin`
        *   Password: `123`

## 📸 Screenshots

*(Optional: You can upload your screenshots to an 'assets' folder in your repo and link them here for a better presentation)*

## 👤 Author

**MHR Ahamed**
*   Student ID: E2410181
*   Faculty of Information Technology, University of Moratuwa

---
*Note: This is an academic project developed for educational purposes.*/resident-management-system.git
    ```
2.  **Database Setup**
    *   Open **XAMPP Control Panel** and start **Apache** and **MySQL**.
    *   Go to `http://localhost/phpmyadmin` in your browser.
    *   Create a new database named `resident_database`.
    *   Select the new database, go to the **SQL** tab, and execute the following script to create the necessary tables and a default admin user:

    ```sql
    CREATE TABLE users (
        Username VARCHAR(50) NOT NULL PRIMARY KEY,
        Password VARCHAR(50) NOT NULL
    );

    INSERT INTO users (Username, Password) VALUES ('admin', '123');

    CREATE TABLE residents (
        id INT AUTO_INCREMENT PRIMARY KEY,
        full_name VARCHAR(100) NOT NULL,
        dob DATE NOT NULL,
        nic VARCHAR(12) UNIQUE NOT NULL,
        address TEXT NOT NULL,
        phone VARCHAR(15),
        email VARCHAR(100),
        occupation VARCHAR(50),
        gender ENUM('Male', 'Female', 'Other') NOT NULL,
        registered_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
    );
    ```

3.  **Run the Application**
    *   Navigate to the project folder and open the solution file (`.sln`) in Visual Studio.
    *   Build and run the project (F5).
    *   **Login Credentials:**
        *   Username: `admin`
        *   Password: `123`

## 📸 Screenshots

*(Optional: You can upload your screenshots to an 'assets' folder in your repo and link them here for a better presentation)*

## 👤 Author

**MHR Ahamed**
*   Student ID: E2410181
*   Faculty of Information Technology, University of Moratuwa

---
*Note: This is an academic project developed for educational purposes.*/resident-management-system.git
    ```
2.  **Database Setup**
    *   Open **XAMPP Control Panel** and start **Apache** and **MySQL**.
    *   Go to `http://localhost/phpmyadmin` in your browser.
    *   Create a new database named `resident_database`.
    *   Select the new database, go to the **SQL** tab, and execute the following script to create the necessary tables and a default admin user:

    ```sql
    CREATE TABLE users (
        Username VARCHAR(50) NOT NULL PRIMARY KEY,
        Password VARCHAR(50) NOT NULL
    );

    INSERT INTO users (Username, Password) VALUES ('admin', '123');

    CREATE TABLE residents (
        id INT AUTO_INCREMENT PRIMARY KEY,
        full_name VARCHAR(100) NOT NULL,
        dob DATE NOT NULL,
        nic VARCHAR(12) UNIQUE NOT NULL,
        address TEXT NOT NULL,
        phone VARCHAR(15),
        email VARCHAR(100),
        occupation VARCHAR(50),
        gender ENUM('Male', 'Female', 'Other') NOT NULL,
        registered_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
    );
    ```

3.  **Run the Application**
    *   Navigate to the project folder and open the solution file (`.sln`) in Visual Studio.
    *   Build and run the project (F5).
    *   **Login Credentials:**
        *   Username: `admin`
        *   Password: `123`

## 📸 Screenshots

*(Optional: You can upload your screenshots to an 'assets' folder in your repo and link them here for a better presentation)*

## 👤 Author

**MHR Ahamed**
*   Student ID: E2410181
*   Faculty of Information Technology, University of Moratuwa

---
*Note: This is an academic project developed for educational purposes.*
