# ASP.NET MVC Test
This is the ASP.NET MVC test for qualified candidates to work with Weepa. Read carefully all instructions before starting the project. It is expected that you spend from 1 to 3 hours to complete the solution.

## Objective
This test aims to evaluate your programming skills in C # and ASP.MVC, following best practices like clean code and convention over configuration, plus your ability to take advantage of Visual Studio 2015 Scaffold and Migrations with Code First Entity Framework 6. Some basic OOP (Object Oriented Programming) knowledge will help you finish faster.

## The Project
First, you should develop a simple REST Web.API for a Social Media like project, providing the following services:

* User registration with username and password;
* Post for a logged Person with text and a uploaded image;
* Messages from one Person (logged) to Another;
* List of all post for a given Person;
* List of all messages exchanged between two People, ordered from the last to the first.

Also, we need an Administration interface to list and eventually block some offensive content and its author. 
* Use the build-in Bootstrap views;
* Use Individual User Accounts and separeted Roles for Admin and regular users.

## Requirements
1. Visual Studio 2015 complete solution
2. Code First with Migrations enabled and Some Seed data (english) to test
3. Both API and Administration interfaces are under login

## The Start 
In this repo, you will find some Model classes to start your project. Those classes are not complete and need some fine adjustmements in order to work properly with VS 2015 Scaffold:
* ModelBase.cs
* Person.cs
* Post.cs
* Message.cs

## The Solution
The solution should have two separated projects, one for Administration and other for the public API, both sharing the same database.

No unity tests are required, but your solution have to work properly.
