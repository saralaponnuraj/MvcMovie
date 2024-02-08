
Lab1
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
To create a new project using the ASP.NET Core Web App (Model-View-Controller) template, i need to start Visual Studio and select Create a new project. In the Create a new project dialog, select ASP.NET Core Web App (Model-View-Controller) > Next. In the Configure your new project dialog, entered MvcMovie for Project name as MvcMovie and select Next. In the Additional information dialog, select .NET 8.0 (Long Term Support) and verified that Do not use top-level statements is unchecked. Then, selected Create
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

Lab3:
Student Id:0850015
Student Name: Sarala Ponnuraj
2024-01-25

Task1: Add search to an ASP.NET Core MVC app
Controller Modifications:
In the controller, updated the action methods that handle the displaying of data to include search functionality.Extracted and filtered data based on the search criteria.
Updated the corresponding views to include a search form and displayed the search results. 
Created a Search Form in the view, design and implement an HTML form that captures the user input for search.
In the controller, created an action method to handle the form submission. Extracted the search query from the form and use it to filter the data.
Implemented the Search Logic and updated data access logic to include the search functionality.
Filtered the data based on the search query and reviewed the return the results.
Verified the displayed Search Results and Modified the view to display the search results.
Used Razor syntax to conditionally render the search results.Tested the web to search functionality to ensure it works as expected.

Observation:
Adding search functionality to an ASP.NET Core MVC app can greatly enhance the user experience and make it easier for users to find the information they are looking for. By allowing users to search for specific content, you can create a more personalized and tailored experience that meets the needs of your users. However, it is important to ensure that the search functionality is properly implemented and tested to ensure that it is working correctly.
The controller's integration of search capabilities demonstrates a commitment to comprehending and meeting user needs, coordinating development activities with the aim of optimizing the user experience in its entirety. A modular code structure is encouraged by the deliberate updating of the controller and views separately, which makes the code more manageable and flexible for future modifications. Intuitivity is given top priority in the HTML search form's thoughtful design and implementation, which promotes increased user engagement and fluid interaction. Keeping focused and well-defined controllers is reflected in the controller's creation of a dedicated action method, which is an example of responsiveness. The application can adapt to changing user requirements thanks to its updated data access logic and adaptable search logic. Efficient data filtering ensures accurate and pertinent search results. 

2024-01-26
Task: To add a new field to an ASP.NET Core MVC app

Accessed the project in Visual Studio to begin the modification process.Opened the model class to add a new field:
Navigated to the relevant model class within the project. Added a new property to the class with the appropriate data type:
Added a new property in the model class, specifying the appropriate data type for the desired field.
Opened the data context class to add a new DbSet for the new property:
Accessed the data context class that is associated with the model and incorporated a new DbSet for the newly added property.
Executed the migration to update the database with the new field.
Executed a migration to apply the changes to the database, ensuring synchronization with the updated model.
Updated the views and controllers to handle the new field.Modified the views and controllers that involve the model to accommodate the new field, ensuring proper handling and integration into the application's user interface and functionality.

Observation:
Adding a new field to an ASP.NET Core MVC app required changes to both the model and data context classes, as well as updating the views and controllers to handle the new field. It is important to carefully plan the addition of a new field and ensure that it is relevant and necessary for the app's functionality. 
Additionally, it is important to properly test the app after adding a new field to ensure that it is working as expected.
the focus was on enhancing the user experience in an ASP.NET Core MVC app by implementing dynamic view rendering using Razor syntax. The specific task involved the addition of a new field to the application. Steps included leveraging Razor syntax to conditionally render search results in the view, providing a customized presentation based on user queries. 
This approach contributes to a more engaging and user-friendly interface. 
Additionally, the task involved adding a new field to the ASP.NET Core MVC app, which could encompass creating the necessary model, updating the database schema if required, adjusting the views and controllers, and ensuring proper validation and handling for the new field's data. The overall aim was to seamlessly integrate the new feature into the application's existing structure while maintaining a high level of user interactivity.

2024-01-31
Steps: Part 9
Opened the ASP.NET Core MVC app in Visual Studio: Navigated to the Model Class: Identify and open the model class that corresponds to the data entity requiring validation.
Apply Data Annotations for Validation Within the model class, use data annotations (attributes) to define validation rules for the properties. For instance, use [Required] for mandatory fields, [StringLength] for maximum length, or custom annotations for specific requirements.

Observation:
ASP.NET Core MVC offers immediate feedback to users, supports client-side and server-side validation, and allows developers to implement custom validation logic. This enhances user experience by providing immediate feedback on input. The system also supports error message localization, allowing applications to display messages in different languages based on user preferences. This allows for better integration with other systems and enhances user experience.
Immediate Feedback to Users: The incorporation of validation provides users with immediate feedback on their input, enhancing the user experience.
I could learn more about the Client-Side and Server-Side Validation: ASP.NET Core MVC supports both client-side and server-side validation. Data annotations primarily handle client-side validation, while server-side validation ensures data integrity on the server.
Custom Validation Logic: Custom validation logic allows developers to implement specific business rules beyond standard annotations.
Error Message Localization: ASP.NET Core MVC supports localization for error messages, enabling applications to display messages in different languages based on user preferences.



2024-02-07
Steps: Part 10

Navigated to the Details Method: Locate and review the implementation of the Details method within the application. This method typically handles the retrieval and display of detailed information for a specific entity.
Examined the Delete Method and explored the implementation of the Delete method within the app. This method is usually responsible for handling the deletion of a specific entity, ensuring proper data removal.
Reviewed the Code Logic: Analyzed the code logic within both the Details and Delete methods. This includes understanding how data is fetched for Details and how deletion is handled for the Delete method.
Checked for Error Handling to ensure that there is appropriate error handling in place, especially when dealing with user requests for details or deletion. The methods should gracefully handle scenarios where requested entities are not found or errors occur during deletion.
Verified Security Measures to confirm that security measures are in place, such as proper authentication and authorization checks, to prevent unauthorized access to the Details and Delete functionalities.

Observations:
The Details method likely involves fetching data from the database and displaying it in a detailed view. Observations may include how efficiently and accurately data is retrieved for presentation.
The Delete method would be observed for its logic in handling entity deletions. This includes confirmation prompts, proper handling of deletion errors, and any additional business rules associated with deletion.
User Experience Considerations insights into the user experience can be gathered by observing the flow and responsiveness of the Details and Delete methods. A user-friendly interface and clear communication of actions taken are essential aspects.
Error Handling Robustness: The robustness of error-handling mechanisms, including informative error messages and graceful degradation, can be evaluated during the examination of these methods.
Security Checks: Observations regarding the implementation of security checks, such as ensuring that only authorized users can access and perform deletions, provide insights into the application's overall security posture.
Code Readability and Maintainability: The examination of the code contributes to insights about code readability and maintainability. Well-structured and easily understandable code ensures future modifications and enhancements can be done efficiently.
Potential Optimization Opportunities: Observations may lead to the identification of potential optimization opportunities, such as improving database queries, enhancing error messages, or refining the user interface for a smoother experience.


