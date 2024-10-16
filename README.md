# CivicTransportCard

# MoneyMe_Challenge
Pre-requisites: Install applications below if not yet installed on your machine
Visual Studio, 
https://visualstudio.microsoft.com/downloads/

SQL Server, SSMS 
SQL SERVER: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
SSMS: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

.Net Core 8
https://dotnet.microsoft.com/en-us/download/dotnet/8.0

After downloading the repository and installing the required applications

Database:
- Open SQL Server Management Studio and Create database "CivicTransportCard" (Your account should have access to create a user and database on your local), in my case I have a windows authentication login with admin access on my sql server
- Create a new login for localuser
   - Click on Security > Logins(Right click) > New Login
       ![image](https://github.com/user-attachments/assets/e9989c06-0990-475f-aaf3-53ed0252e655)

      Login Type: SQL Server Authentication;
      Login Name: localUser;
      Password: password;
   - On the server roles, check the checkbox for public and sysadmin
     ![image](https://github.com/user-attachments/assets/9d6ef35d-df51-4dcb-b30f-3e9318b26aaa)
    
- Open the downloaded Solution then right click on the CivicTransportCard.DB Project then click Publish

- Click the Edit button then Go to Browse Tab and fill up the login credential for the local user that you just created, please refer to screenshot below
![image](https://github.com/user-attachments/assets/711c251b-eca0-4cc8-a5c0-cfca9dda1a24)


-Then click Publish button
![image](https://github.com/user-attachments/assets/3b68971c-d1b1-4b17-890d-5caa0b8367e6)


It should show that the publish completed successfully
you may also check that the tables have been created under CivicTransportCard database
![image](https://github.com/user-attachments/assets/2c16fad0-d088-40b0-940e-236092d90a76)


Thing/s to check:

Bewfore you run the application,
The API Project and Windows Forms project should run simultaneously as the Winforms project is calling the endpoint in the WebAPi Project.

To set it to run simultaneously, please see screenshots below
![image](https://github.com/user-attachments/assets/ebc8c87d-08f3-40d0-b8ed-057aad7b546a)

![image](https://github.com/user-attachments/assets/fccb1438-6e8e-4d1c-864d-f97a2f60d29a)



Check the App.config file in CivicTransportCard.WinForms Project, the baseAPIURL value should be the same URL if you run the WebAPI Project
![image](https://github.com/user-attachments/assets/fce7056c-b067-4b21-91c5-2c4be02d99b5)

