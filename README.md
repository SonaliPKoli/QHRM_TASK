# QHRM_TASK - Products API

This is a simple ASP.NET project that provides an API for managing products using Dapper as the data access technology. 

This readme file will guide you on how to run and use the project.

# Prerequisites
Before running the project, make sure you have the following prerequisites installed on your machine:

.NET runtime - version 6.0 or later

SQL Server or SQL Server Express

# Getting Started
1.Clone the repository or download the source code to your local machine.

  git clone https://github.com/SonaliPKoli/QHRM_TASK.git
  
  
2.Open the project in your preferred IDE or text editor.

3.Create a database for the project in your SQL Server instance. I used SQL Server Management Studio tool. Remember the connection string for later use.

I have provided .bacpac file containing the db with the table, You can import it in the SSMS.

Import the same in SSMS.

4.Open the appsettings.json file in the project. Update the DefaultConnection connection string value with your SQL Server connection details.

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=**localhost**;Database=**YourDatabaseName**;Trusted_Connection=True;"
  }
}


5.Build the project to restore the NuGet packages.

# API Endpoints
The project provides the following API endpoints:

GET /api/products - Retrieves all product details.

GET /api/products/{productid} - Retrieves a specific product detail by ID.

POST /api/products/add - Adds a new product to the database. Requires a JSON payload with product_name and product_price properties.

POST /api/products/update - Updates an existing product in the database. Requires a JSON payload with id, product_name, and product_price properties.

POST /api/products/delete - Deletes a product from the database by ID. Requires a JSON payload with productid property.

**Note**: Replace localhost with the appropriate domain or IP address if running the project on a remote server.

# **Output (Screenshots):**

# Home:
![image](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/652e3690-bed6-4a8f-a752-707804d268d7)

# Details (initial):
![Screenshot (68)](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/cede9955-4d99-4f3a-b71b-ce52a5f6b50f)

# Search By ID:
![Screenshot (65)](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/96db23c1-4d36-4120-8a47-286fee980aca)

# Add:
![Screenshot (63)](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/d0a40860-c784-47e1-b0bd-85cf7ea39634)

# Update:
![Screenshot (66)](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/28e18729-bedd-4b38-bf4b-ebec5e30919d)

# Delete:
![Screenshot (67)](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/bbb58da8-eef8-4194-8f2c-3c3f4ad43217)

# Details (after changes):
![Screenshot (64)](https://github.com/SonaliPKoli/QHRM_TASK/assets/86517758/6149d30f-cec3-43fc-a02c-d0a9830c9495)


# Conclusion
This will help set up and run the QHRM_TASK_DAPPER project. You can now use the API endpoints to manage products in the database.
