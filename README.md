# Custom Register And Login For ASP.NET MVC Web Application

## How To Use

 You should replace ProjectName in these files with your own project name and replace User.cs with your own User Class. This code is written for a db first workflow so if you use code first workflow, instead of database entites you must use a dbcontext but there are no major changes needed.

### 1- Controllers Directory

Currently contains AccountController which has the Login and Register actions

### 2- Models Directory

Currently contains User class and it's properties.
This is the class which is mapped to our database.

### 3- Views Directory

Currently contains Login and Register Views which are basically just forms to be submited.

### 4- ViewModels Directory

Currenty contains LoginViewModel and RegisterViewModel.
The LoginViewModel which has username and password properties is the viewmodel which we send to the Login view.
The RegisterViewModel has some other properties other than username and password like confirm password which is going to be compared to the password field.