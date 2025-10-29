Resident Management System for Grama Niladhari Division
A standalone desktop application developed as part of the ITE 1943 – ICT Project for the Bachelor of Information Technology degree at the University of Moratuwa.
Submitted by: MHR Ahamed (Rihamhanifa)
Index Number: E2410181
![alt text](INSERT_YOUR_DASHBOARD_SCREENSHOT_URL_HERE)
Screenshot of the main application dashboard.
📋 Table of Contents
About The Project
Problem Statement
Key Features
Built With
Getting Started
Prerequisites
Installation
Screenshots
Contact
📖 About The Project
The Resident Management System is a C# Windows Forms desktop application designed to replace the inefficient and error-prone manual, paper-based record-keeping methods used in Grama Niladhari (GN) divisions.
This system provides a secure, centralized, and user-friendly digital solution for GN officers to manage resident information effectively. It automates the entire data management lifecycle, from data entry and validation to quick retrieval and secure storage, thereby improving administrative efficiency and data accuracy.
🎯 Problem Statement
Traditional record-keeping in GN divisions suffers from several critical issues:
High Risk of Human Error: Manual data entry leads to inaccurate and inconsistent records.
Data Vulnerability: Physical documents are susceptible to loss and damage.
Time-Consuming Processes: Searching for and retrieving specific resident information is a slow and manual task.
Lack of Data Validation: There is no mechanism to enforce correct data formatting, leading to poor data quality.
Poor Security: Sensitive personal data is not adequately protected.
This application was built to solve these problems by providing a robust and modern digital alternative.
✨ Key Features
Secure User Authentication: Access to the system is protected by a username and password.
Centralized Dashboard: An all-in-one interface to view and manage all resident records.
Full CRUD Functionality: Easy-to-use forms for Creating, Reading, Updating, and Deleting resident data.
Powerful Search: Instantly filter thousands of records by Name, NIC, or Address.
Robust Data Validation:
Checks for required fields (Name, NIC, Address, Gender).
Validates the format for Sri Lankan NICs (both old 10-character and new 12-digit formats).
Validates the format for phone numbers (optional, but must be 10 digits if provided).
User-Friendly Interface:
A clean, modern dark-themed design.
Logical Tab Order for easy keyboard navigation.
Helpful Tooltips to guide the user.
🛠️ Built With
This project was built using the following technologies:
Backend:
C# (C-Sharp)
.NET Framework 4.8
Frontend:
Windows Forms (WinForms)
Database:
MySQL (managed via XAMPP)
IDE:
Microsoft Visual Studio 2022
🚀 Getting Started
To get a local copy up and running, follow these simple steps.
Prerequisites
You will need the following software installed on your machine:
Windows 10 or 11
.NET Framework 4.8 or later (usually included with Windows updates).
XAMPP: A local server environment that includes MySQL.
Download from Apache Friends
Installation
Set up the Database:
Start the Apache and MySQL modules from the XAMPP Control Panel.
Go to http://localhost/phpmyadmin in your web browser.
Create a new database named resident_database.
Select the new database, go to the "SQL" tab, and execute the following SQL script to create the necessary tables:
code
SQL
-- Users Table
CREATE TABLE users (
    Username VARCHAR(50) NOT NULL PRIMARY KEY,
    Password VARCHAR(50) NOT NULL
);

-- Residents Table
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

-- Insert a default user
INSERT INTO users (Username, Password) VALUES ('admin', '123');
Run the Application:
Clone this repository or download the source code.
Open the solution file (ResidentManagement-System.sln) in Visual Studio.
Press the "Start" button (or F5) to build and run the project.
Log in with Username: admin and Password: 123.
🖼️ Screenshots
<p align="center">
<img src="<INSERT_YOUR_LOGIN_SCREENSHOT_URL_HERE>" width="45%" alt="Login Screen">
&nbsp;&nbsp;&nbsp;&nbsp;
<img src="<INSERT_YOUR_VALIDATION_SCREENSHOT_URL_HERE>" width="45%" alt="Validation Error">
</p>
<p align="center">
<em>Login Screen and an example of Input Validation.</em>
</p>
<p align="center">
<img src="<INSERT_YOUR_SEARCH_SCREENSHOT_URL_HERE>" width="70%" alt="Search Results">
</p>
<p align="center">
<em>Powerful search filters the data grid instantly.</em>
</p>
📧 Contact
MHR Ahamed (Rihamhanifa) - [Your Email Address] - [Link to your LinkedIn profile, optional]
Project Link: https://github.com/Rihamhanifa/ResidentManagementSystem
