using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Expand on the Company class code by
        // Adding an Employees property (Its type should be List<Employee>)
        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set;}



            //Create a constructor method that accepts two arguments:company's name and creation date.
            public Company(string name, DateTime createdOn)
            {

                // 1. The name of the company
                // 2. The date it was created
            Name = name; // Set the Name property // Set the company's name.
            CreatedOn = createdOn; // Set the CreatedOn property // Set the company's creation date.
            // Setting the value of Employees in the constructor as a new List<Employee> (News Flash: Declaring a property gives it an initial vlaue of null). This will allow you to add newly created employees to the Employees list in the final step below.
            Employees = new List<Employee>(); // Initialize the list of employees.//Initialize the Employees property with a new list

            }

            // Method to list all employees and their details.
            public void ListEmployees()

            {
                // Iterate over each employee in the list.
                foreach (Employee employee in Employees)
                
                {
                    //// The Company class should also have a ListEmployees() method which writes a string to the console about each employee, such as "Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."
                    // Print the employee's details.
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}.");
                }
            }
    }
 }







