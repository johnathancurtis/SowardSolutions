# SowardSolutions
This is a build of the demo MVC application from Adam Freeman's ASP.Net Core 3 text book. This is for demonstration purpose. 

## Link 
[https://www.apress.com/gp/book/9781484254394]
## Build Script

        dotnet new globaljson --sdk-version 5.0.103 --output SowardSolutions/ConsultingProducts
        dotnet new web --no-https --output SowardSolutions/ConsultingProducts --framework net5.0
        dotnet new sln -o SowardSolutions
        dotnet sln SowardSolutions add SowardSolutions/ConsultingProducts 
        dotnet new xunit -o SowardSolutions/ConsultingProducts.Tests --framework net5.0
        dotnet sln SowardSolutions add SowardSolutions/ConsultingProducts.Tests 
        dotnet add SowardSolutions/ConsultingProducts.Tests reference SowardSolutions/ConsultingProducts 
        
## Part 2
![Part2](Archive/LAB_1B_Part2.PNG)

## Part 3
What is Entity Framework?

Enity Framework is Microsofts Object to relational mapping (ORM) framework. 
It is used to link databases and web applications together.
What is a Connection String?

A connection string is a string created that is used to connect to a SQL database from the code itself.
It contains the database being used, and the login for the database.
What is a Database Context?

Database Context is the mapping of a SPECIFIC database with a schema the program can understand.
What is a Model Repository?

A model repository is used to reduce repetition in your database, and can be used to retrieve a sequence of database objects.
This sequence can be queried, and any class that depends on the model repository can utilize these features.
Migration vs Scaffolding?

Migration is the compiler creating database tables and schema for you with the context provided.
Scaffolding is the compiler creating code for cshtml and html documents with the context provided.

## Part 3
Totally forgot to snip seeding the database.

## Part 4
