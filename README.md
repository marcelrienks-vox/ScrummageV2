# PieceOfCake [![Build status](https://ci.appveyor.com/api/projects/status/cmaiaeysv5182qiw?svg=true)](https://ci.appveyor.com/project/celemar/pieceofcake)
**NOTE: Still in Development!**  
**P**iece **O**f **C**ake is a **POC** / Template for a three layered project (Data, Service and Web)

**Data**  
Use Entity Frameworks Code First generation, and the Repository / Unit of work Pattern to create a Generic point of entry for all Models.

**Service**  
Use WebAPI to expose basic CRUDL functionality of each model in Data, through REST services.
These services will be auto generated using templates.

**Web**  
Use MVC to expose a graphic interface over all the Service functions available.

This will allow Customers to either use the Service layer through REST, or the Web layer to perform CRUDL functionality.

## TECHNOLOGIES AND PATTERNS: ##
This project is a test bed for implementing the Repository and Unit of Work Pattern for an MVC 5 project.
It uses Code First approach through Entity Framework 6.
  
There are aslo examples of how to use Async Awaits repository and Controller calls (not currently implemented).
Twitter Bootstrap has been used for presentation.

### 3rd Party Libraries ###
* GraphDiff  
Used to update the entire graph tree of a context model, including relations

* AutoMapper  
Used to map two objects together (Convert from one to another)

## DEVELOPMENT: ##
* Data: Update models to be for a generic template
* Services: Update services to match the new models
* Services: Update Unit tests
* Services: Implement auto generation of services per model
* Web: Update interface to allow all crudl functions for models
* Web: Update Unit tests

### Todo ###
* Investigate using Async repository methods
* Investigate using auto code generation to create api's and api tests based on this controller as template
* determine weather or not updating a model and it's relations should be done, or rather have multiple API calls be made, or use hypermedia
* Switch PieceOfCake.Web to use PieceOfCake.Services instead of going to PieceOfCake.Data directly
* Add validation to prevent role from being deleted if it's assigned to a User
* Investigate using Mock DbSet instead of having a fake Repository
* verify of username, password on create of User without causing a post back
* add functionality to User edit for Password and Avatar (including validation)
* investigate creating unit tests for the repository, by creating a fake contaxt/dbset class, which can be dependancy injected in?

## RESOURCES: ##
### Roles ###
This allows administrators to have basic CRUDL functionality of user Roles.

### Users ###
This allows administrators to have basic CRUDL functionality of Users.

## DOMAIN ##
### Roles ###
Users (n)  
int Id (PK, Identity)  
string Title (Required, Max=30)  
string Description (Max=180)  

### Users ###
Roles (n)  
int Id (PK, Identity)  
string Name (Required, Max=30)  
string Username (Required, Max=30, Unique)  
string Password (Required, Max=30)  
string Email (Required)  

## NOTES: ##
### Migration ###
The migration commands to run from the 'Package Manager Console'.

**Enable-Migrations**  
This will enable migrations to be used. 

**Add-Migration**  
This will scaffold the next migration based on changes you have made to your model.
Or this will create the initial migration if run for the first time.

**Update-Database**  
This will apply any pending changes to and or create the database.

## ERRORS: ##
### cannot attach the file as database  ###
Ensure the Data Connection is deleted in 'Server Explorer' in VS2012.
Ensure Database is deleted in all versions of localdb from 'SQL Server Object Explorer' in VS2012.
Ensure the database is not attached in SqlExpress.

If this does not solve the issue, open the "Developer Command Propmpt for VisualStudio" under your start/programs menu.
Run the following commands:

sqllocaldb.exe stop v11.0
sqllocaldb.exe delete v11.0
