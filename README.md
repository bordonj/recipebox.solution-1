# Recipe Box

A web application to keep track of and categorize recipes. Any user of this website will be able to view a list of all recipes created and a list of their ingredients and instructions. If the user enrolls and logs in- they will be able to create, edit, and delete recipes as well as their ingredients and instructions to their desired specifications.

#### Authored by Erika Debelis, Godfrey Owidi, and Jenn Bordon

## Technologies Used

* _C#_
* _MySQL_
* _My SQL Workbench_
* _VS Code_
* _Git BASH_
* _LINQ_
* _ASP .NET CORE_
* _Entity Framework Core_

## Setup/Installation Requirements

1. Download or clone the https://github.com/ErikaDebelis/recipebox.Solution to your local machine

2. Open git BASH terminal and navigate to the recipebox folder within the directory

3. Create appsettings.json file in the recipebox directory of recipebox.Solution and add the following code to the file: 
    ``touch appsettings.json``

```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to remove the ``{YOUR_USERNAME_NAME}`` and ``{YOUR_PASSWORD}`` and fill in the the code snippet with your username for MySQL, and MySQL password _Do not include the curly brackets in your code snippet of appsettings.json_

4. Make sure EF Core is installed to create and utilize migrations. Run the following code in the git BASH terminal to install.
    ``$ dotnet tool install --global dotnet-ef --version 3.0.0``

5. Run "dotnet restore" in the git BASH terminal to install needed dependencies.
    ``$ dotnet restore``

6. Run "dotnet build" in the git BASH terminal to minify the code.
    ``$ dotnet build``

7. Run "dotnet ef database update" in the git BASH terminal create the database outlined from the Model within the project.
    ``$ dotnet ef database update``

8. Run "dotnet run" in the git BASH terminal to  minify the code, and run the project in the terminal.
    ``$ dotnet watch run``

9. View the website by visiting localhost:5000/ in a new web browser( such as google chrome) tab!

## Bugs

_no known bugs at this time_

## License

_MIT_

_Copyright (c) 2021 Erika Debelis_

if any issues are discovered while navigating the site, please let us know! It will help us learn and grow!

## Contact Information

Erika Debelis _erika.debelis@gmail.com_, Godfrey Owidi _godfreyowiidi@gmail.com_, and Jenn Bordon _jennifer.bordon@gmail.com_
