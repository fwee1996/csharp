// Create an Employee.cs file and then define a class for Employee. An employee has the following properties.
// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)

using System;
using System.Collections.Generic;

namespace Classes
{
    public class Employee
    {
public string FirstName { get; set;}
public string LastName { get; set;}
public string Title { get; set;}
public DateTime StartDate { get; set;}
   

    public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            FirstName = firstName; 
            LastName = lastName; 
            Title=title;
            StartDate = startDate; 
        }
        
        }}