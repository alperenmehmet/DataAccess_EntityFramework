# DataAccess
Entity Framework is a data access framework provided by Microsoft. 
It helps to establish relation and data structure in the application.
There are three approach Entity Framework provides:
- [Model First](#modelfirst)
- [Database First](#databasefirst)
- [Code First](#codefirst)
---
The Code First approach is the recommended approach with Entity Framework.
Especially, if you develop an application from scratch, 
Code First approach will provide you all you need. 
### Project Overview
I will use code-first approach in this project. First of all I create a new 
blank-solution named **BlogProject**. In the solution layer, create two project.
One of that will **DataAccess** and the other will be **Entity**.
We have to add Entity Framework packages **Entity** layer and **DataAccess** layer.
To do this click right click at the references, Manage NuGet Packages and install Entity Framework packages.
Do the same thing for **DataAccess** layer. 
In the **Entity Layer** we will create *BaseEntity* class, *Enums* 
and *AppUser*, *Article*, *Category*, *Comment*, *Writer* class.
For the last go to the **DataAccess** layer, add *ApplicationDbContext*.
### Additional Information
If you are having trouble using this project, please open a new issue and describe your problem. Liked the project? 
Just give it a star.


 
