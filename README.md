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

Data model diagram: 

<img width="545" alt="Screen Shot 2024-02-01 at 2 54 47 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/cd207ccf-23ed-4b3b-8265-341c903d2a64">

Sample question:

<img width="539" alt="Screen Shot 2024-02-21 at 1 22 30 am" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/197b5302-091b-4b81-856a-584fcced9379">

_Note: my explanations and documentation below will cover the instructor entity for a simplified explanation. 
I have created CRUD operations for both Instructor and Courses.__

I used lucidchart to create a simple visual diagram of my code design:

<img width="452" alt="Screen Shot 2024-02-21 at 2 09 00 am" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/1f34f63a-8fae-440f-99e8-39e12fa79792">

Dependency Injection (DI):

DI is employed to achieve Inversion of Control (IoC), which helps in decoupling components and managing their dependencies.
In InstructorController, InstructorManager is injected via constructor injection, facilitated by ASP.NET Core's built-in DI container. This separation allows for more manageable and testable code.

Repository Design Pattern:

The InstructorManager acts as a repository for the Instructor entity, abstracting the data access logic into a distinct layer. This allows business logic to interact with the data source through a simplified interface.
CRUD operations are encapsulated within the InstructorManager, which hides the complexity of the underlying data access mechanism using Entity Framework Core.

API endpoints tested using Postman:

[HttpGet] Gets all instructors 

<img width="1440" alt="Screen Shot 2024-02-20 at 5 59 13 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/c7886ecd-0c9b-43f8-ad9f-24bd2c8c9d39">

[HttpGet("{InstructorID}")] Gets a single instructor based on InstructorID

<img width="1440" alt="Screen Shot 2024-02-20 at 5 59 20 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/fe0db8d3-6a96-4e45-a917-ef3b67d1b28d">

[HttpPost] Adds a new instructor to the database

<img width="1440" alt="Screen Shot 2024-02-20 at 6 00 33 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/a04177b1-a811-48fc-8a78-a2dd32fcb1ed">

<img width="1440" alt="Screen Shot 2024-02-20 at 6 00 39 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/295f9297-2d23-44c1-a1b2-9f11ac38c9d1">

Heres a screenshot displaying that invalid data will not be inputted due to server side validation from data annotations in our models:

<img width="1440" alt="Screen Shot 2024-02-20 at 6 00 18 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/3d1739bf-d87c-4bad-9ad3-9a2cba083abd">

[HttpPut] Updates the details of an existing instructor in the database

<img width="1440" alt="Screen Shot 2024-02-20 at 6 00 52 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/8d8cb5fe-e1cf-460c-8f35-ae57533a99ea">

<img width="1440" alt="Screen Shot 2024-02-20 at 6 01 08 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/c9dd150c-4b0b-45e0-a63c-e2933d616c09">

[HttpDelete] Removes instructor from database

<img width="1440" alt="Screen Shot 2024-02-20 at 6 01 25 pm" src="https://github.com/roylohhh/SchoolWebApi/assets/101264393/bfa8ffaa-2fbb-452a-998c-6f7defc6392f">
