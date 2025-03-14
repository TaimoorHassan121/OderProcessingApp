# Create Project named as OrderProcessingApp using Asp .Net Core 8 Entityframwork core MVC Restfull Api
# Install required Package 
  1.Micreosoft EntityFrameorkCore (8.0.14) # using for framwork
  2.Micreosoft EntityFrameorkCore Desing (8.0.14) # Uaing desing Controller and Views 
  3.Micreosoft EntityFrameorkCore.SQLSwever (8.0.14) # Using for connection with SQL Server
  4.Micreosoft EntityFrameorkCore.Tool (8.0.14) # Using for migration to database
  5.Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation # Using for runtime changing in Views
  6.Xunit   # Using for testing
# Desing Model calss for database named Order.
# Create folder Data and create a class named as ApplicationDbContext for Context file.
  In Application Context file we place our table detail which migrate and generate tabe in sql server.
# Configure ApplicationDbContext in Program file to us as dependency injection in controller.
# Add Connection string in appsettings.json file to connect with sql server.
# Add migration and update database using package manage console to migrate and craate database in sql sqrver.
# Create Controller and View for functioning or to CRUD function.
# Create Busniss Logic to get the percentage of amount or create logic as per request.
    All above code i made in main branch now i change my branch to taimoorTesting
# I create a folder as Testing and Create our testing Class OrderServiceTesting
# All this work done in Git Version on CI/CD pipeline as i push data on my git it will automatically update the system



# Using of Project:

  1. Frist clone my repository in you system
  2. Open file in Visual Studio 2022
  3. Change the server name in appsettings.json ("Server=localhost\\MSSQLSERVER02;Database=OrderProcessing;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true")
  4. Now Run migration
     a. Add- Migrations
     b. Migration name like (FirstMigration)
     c. then run command (Update-Database)
  5. Now Run the project
  6. Click on Create Order and enter you data
  7. to view the record click on View Order
  8. End


