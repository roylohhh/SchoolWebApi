As this is a backend focused project, there will be no front end, and Postman was used to test API endpoints.
I was provided with a data model diagram and a few sample questions to practice for a test (which covers mostly ASP.NET Core MVC). 
I decided to create an ASP.NET Core Web Api project with one of the sample questions. 

The purpose of this project is to display an understanding of these backend concepts:
- C#
- ASP.NET Core
- Repository design patterns and dependency injections
- Entity Framework Core (DBContext and Migrations)
- MVC Architectural pattern
- Building REST apis

This is the data model diagram: 

<img width="545" alt="Screen Shot 2024-02-01 at 2 54 47 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/cd207ccf-23ed-4b3b-8265-341c903d2a64">

Sample question:

<img width="539" alt="Screen Shot 2024-02-21 at 1 22 30 am" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/197b5302-091b-4b81-856a-584fcced9379">

I used lucidchart to create a simple visual diagram of my code design:

<img width="452" alt="Screen Shot 2024-02-21 at 2 09 00 am" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/1f34f63a-8fae-440f-99e8-39e12fa79792">

Dependency Injection (DI):

DI is employed to achieve Inversion of Control (IoC), which helps in decoupling components and managing their dependencies.
In InstructorController, InstructorManager is injected via constructor injection, facilitated by ASP.NET Core's built-in DI container. This separation allows for more manageable and testable code.

Repository Design Pattern:

The InstructorManager acts as a repository for the Instructor entity, abstracting the data access logic into a distinct layer. This allows business logic to interact with the data source through a simplified interface.
CRUD operations are encapsulated within the InstructorManager, which hides the complexity of the underlying data access mechanism using Entity Framework Core.



