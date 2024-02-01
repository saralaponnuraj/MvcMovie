Date: 2024-01-12
Time: 1109
Student ID: 0850015

Task1: Create a web app using ASP.NET Core MVC and Visual Studio

Problem: 
How to install and configure the required tools and frameworks?
How to create a new project using the ASP.NET Core Web App (Model-View-Controller) template?
How to run and test the web app locally?

Solution:
To install and configure the required tools and frameworks, i need to download and install Visual Studio 2022 Preview with the ASP.NET and web development workload. I installed .NET 8.0 (Long Term Support), which is the target framework for ASP.NET Core 8.0
To create a new project using the ASP.NET Core Web App (Model-View-Controller) template, i need to start Visual Studio and select Create a new project. In the Create a new project dialog, select ASP.NET Core Web App (Model-View-Controller) > Next. In the Configure your new project dialog, entered MvcMovie for Project name as Lab1_Assignment and select Next. In the Additional information dialog, select .NET 8.0 (Long Term Support) and verified that Do not use top-level statements is unchecked. Then, selected Create
To run and test the web app locally, i need to selected Ctrl+F5 to run the app without the debugger. Visual Studio will displayed a dialog to trust the IIS Express SSL certificate. Selected Yes if you trust the certificate. Then, Visual Studio will run the app and open the default browser.

Task2:
Add a controller to an ASP.NET Core MVC application.

Problems:
How to name the controller class and the methods inside it?
How to use the scaffolding(tools) feature to generate a controller template?
How to specify the routing logic that maps the URL to the controller action?

Solution:
The controller class named as "HelloWorldController".
To use the scaffolding(tools) feature, right-clicked the Controllers folder in the Solution Explorer and selected Add > New Scaffolded Item. Then, select MVC Controller - Empty and clicked on Add. Entered the name of the controller class and click Add again. 
To specify the routing logic, use the [Route] attribute on the controller class or the action methods. The [Route] attribute takes a parameter that defines the URL pattern that matches the controller or the action. For example, [Route("HelloWorld")] on the controller class means that any URL that starts with "HelloWorld" will be handled by this controller. [Route("Welcome")] on the action method means that the URL "HelloWorld/Welcome" will invoke this action.


Task3: Create a view for the Index action method of the HelloWorldController class that displays a welcome message and the current date and time.

Problems:
How to create a view file and associate it with a controller action method?
How to use Razor syntax to write dynamic HTML code in the view file?
How to pass data from the controller to the view?

Solutions:

1. In the Solution Explorer, right-click on the Views folder and select Add > New Folder. Named the folder as `HelloWorld`.
2. Right-clicked on the `HelloWorld` folder and selected Add > New Item.
3. In the Add New Item dialog, selected Show All Templates.
4. In the search box in the upper-right corner, entered `view`.
5. Then Selected Razor View - Empty and kept the default name `Index.cshtml`.
6. Replaced the contents of the `Views/HelloWorld/Index.cshtml` Razor view file.
7. In the `HelloWorldController` class, replaced the `Index` method.

Lab2
Student Id:0850015
Student Name: Sarala Ponnuraj

2024-01-18

Task1: Add a model to an ASP.net Core MVC app
1) Added a data model class : A Movie class is created in the Models folder to represent the data model for the application and in MovieContext class, derived from DbContext, is created in the Data folder. This class represents the database context and includes a DbSet for the Movie model.
2) Initiated the Migration from tools menu selected NuGet Package Manager and chosen Package Manager Console.
3) Tested the app by running the app and by selecting the Movie App link and examined the generated database context class and registration.
4) Examined the Migration Initialcreate.cs migration file 

Task2: Work with a database in an ASP.NET Core MVC app
1) Examined the database from view menu option opened the SQL Server Object 
2) Created a new class named SeedData in the models folder and replaced the code and added new movie list.
3) Added the seed initializer replaced the contents of program.cs class and when executed the code could see the list of movie seeded in the code.

Lesson Learnt:
Step-by-step guide to creating a simple web application that allows to create, read, update, and delete data from a database.
Controller methods: Learnt how to create and use controller methods to handle HTTP requests.
Views: Understood how to create and use views to display data to the user.
Model binding: Explored how to use model binding to map HTTP requests to action method parameters.
Tag helpers: Learnt how to use tag helpers to generate HTML elements in Razor views.








