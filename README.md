# Custom Register And Login For ASP.NET MVC Web Application

## How To Use

As you can see are some directories in this repository. you should replace ProjectName in these files with your own project name and replace User.cs with your own User Class. Also if you use code first workflow instead of Data base entites you must use a dbcontext.

### 1- Controllers Directory

Currently contains AccountController which has the Login and Register actions

### 2- Models Directory

Currently contains User class and it's properties.
This is the class which is mapped to our database.

### 3- Views

Currently contains Login and Register Views which are basically just forms to be submited.

### 4- ViewModels

Currenty contains LoginViewModel which has username and password properties.
this is the viewmodel which we send to the Login view, and the RegisterViewModel which has some other properties but basically does the same thing in Register View.