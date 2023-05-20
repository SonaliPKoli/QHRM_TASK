# QHRM_TASK_DAPPER - Products API

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

3.Create a database for the project in your SQL Server instance. You can use SQL Server Management Studio or any other database management tool of your choice. Remember the connection string for later use.

4.Open the appsettings.json file in the project. Update the DefaultConnection connection string value with your SQL Server connection details.

5.Build the project to restore the NuGet packages.

# API Endpoints
The project provides the following API endpoints:

GET /api/products - Retrieves all product details.

GET /api/products/{productid} - Retrieves a specific product detail by ID.

POST /api/products/add - Adds a new product to the database. Requires a JSON payload with product_name and product_price properties.

POST /api/products/update - Updates an existing product in the database. Requires a JSON payload with id, product_name, and product_price properties.

POST /api/products/delete - Deletes a product from the database by ID. Requires a JSON payload with productid property.

**Note**: Replace localhost with the appropriate domain or IP address if running the project on a remote server.

# Example Usage
Here are some example requests using cURL:

1.Get all product details:

curl -X GET https://localhost:5001/api/products


2.Get a specific product detail by ID:

curl -X GET https://localhost:5001/api/products/1

3.Add a new product:

curl -X POST -H "Content-Type: application/json" -d '{"product_name":"New Product","product_price":9.99}' https://localhost:5001/api/products/add


4.Update an existing product:

curl -X POST -H "Content-Type: application/json" -d '{"id":1,"product_name":"Updated Product","product_price":19.99}' https://localhost:5001/api/products/update

5.Delete a product:

curl -X POST -H "Content-Type: application/json" -d '{"productid":1}' https://localhost:5001/api/products/delete


# Conclusion
This will help set up and run the QHRM_TASK_DAPPER project. You can now use the API endpoints to manage products in the database.
